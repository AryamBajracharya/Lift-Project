using LiftDemo_A;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift_Project
{
    public partial class Form1 : Form // inheritance
    {
        public bool isClosing;
        public bool isOpening;
        public bool isOpen;
        public bool doorsClosed = true; 


        int doorMaxOpenWidth;
        int doorSpeed = 8;
        int liftSpeed = 10;
     
        private int currentFloor = 0; // 0 represents the ground floor, 1 represents the first floor.
        private Lift lift;
        DataTable dt=new DataTable();
        Db_context db_Context = new Db_context();
        

        public Form1(bool isOpening)
        {
            InitializeComponent();
            this.isOpening = isOpening;
            lift = new Lift(mainElevator, btn_1, btn_G, this.ClientSize.Height, liftSpeed, liftTimerUp, liftTimerDown, fFloorBack, gFloorBack,doorTimer, pictureBox1);


            doorMaxOpenWidth = mainElevator.Width / 2;

            dataGridView.ColumnCount= 2;
            dataGridView.Columns[0].Name = "Time";
            dataGridView.Columns[1].Name = "Events";

            dt.Columns.Add("Time");
            dt.Columns.Add("Events");

            pictureBox1.Visible = false;

        }

        private void logEvents(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            dt.Rows.Add(currentTime, message);
            dataGridView.Rows.Add(currentTime,message);

            db_Context.InsertLogsIntoDB(dt); 

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            db_Context.LoadLogsfromDB(dt, dataGridView);
        }

        private async void btn_1_Click(object sender, EventArgs e) // Asynchronous Method-Background worker 
        {
                btn_Close_Click(null, EventArgs.Empty);
                await Task.Delay(1000);
                lift.SetState(new MovingUpState());
                lift.LiftTimerUp.Start();
                logEvents("lift first floor");
                await Task.Delay(3000);
                btn_open_Click(null, EventArgs.Empty);
        }

        private async void btn_G_Click(object sender, EventArgs e)
        {
                btn_Close_Click(null, EventArgs.Empty);
                await Task.Delay(1000);
                lift.SetState(new MovingDownState());
                lift.LiftTimerDown.Start();
                logEvents("lift ground floor" );
                await Task.Delay(3000);
                btn_open_Click(null, EventArgs.Empty);
        }

        public void liftTimerUp_Tick(object sender, EventArgs e) //Encapsulation
        {
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            currentFloor = 1;
            lift.MovingUp();
            
        }

        public void liftTimerDown_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox1.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            currentFloor = 0;
            lift.MovingDown();
           
        }

        private async void up_button_Click(object sender, EventArgs e)
        {
            btn_Close_Click(null, EventArgs.Empty);
            await Task.Delay(1000);
            lift.SetState(new MovingUpState());
            lift.LiftTimerUp.Start();
            logEvents("lift first floor");
            await Task.Delay(3000);
            btn_open_Click(null, EventArgs.Empty);
        }

        private async void down_button_Click(object sender, EventArgs e)
        {
            btn_Close_Click(null, EventArgs.Empty);
            await Task.Delay(1000);
            lift.SetState(new MovingDownState());
            lift.LiftTimerDown.Start();
            logEvents("lift ground floor");
            await Task.Delay(3000);
            btn_open_Click(null, EventArgs.Empty);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            isOpening = true;
            isOpen = true;
            isClosing = false;
            doorTimer.Start();
            btn_Close.Enabled = false;
            
            logEvents("Lift open");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            isOpening = false;
            isOpen = false;
            isClosing = true;
            doorTimer.Start();
            logEvents("Lift closed");
        }

        private void door_Timer_Tick(object sender, EventArgs e) //Opening and Closing 
        {
            if (currentFloor == 0) // Ground floor
            {
                if (this.isOpening)
                {
                    if (doorLeft_G.Left > doorMaxOpenWidth / 2 + 65)
                    {
                        doorLeft_G.Left -= doorSpeed;
                        doorRight_G.Left += doorSpeed;

                        pictureBox5.Visible = true;
                        pictureBox4.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = false;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_Close.Enabled = true;

                        pictureBox5.Visible = true;
                        pictureBox4.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = false;
                    }
                }

                if (this.isClosing)
                {
                    if (doorLeft_G.Right < mainElevator.Width + doorMaxOpenWidth / 2 + 65)
                    {
                        doorLeft_G.Left += doorSpeed;
                        doorRight_G.Left -= doorSpeed;


                        pictureBox5.Visible = true;
                        pictureBox4.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = false;
                    }
                    else
                    {
                        doorTimer.Stop();

                        pictureBox5.Visible = true;
                        pictureBox4.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = false;

                    }
                }
            }
            else if (currentFloor == 1) // First floor
            {
                if (this.isOpening)
                {
                    if (doorLeft_1.Left > doorMaxOpenWidth / 2 + 65)
                    {
                        doorLeft_1.Left -= doorSpeed;
                        doorRight_1.Left += doorSpeed;


                        pictureBox4.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox5.Visible = false;
                    }
                    else
                    {
                        doorTimer.Stop();
                        btn_Close.Enabled = true;

                        pictureBox4.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox5.Visible = false;
                    }
                }

                if (this.isClosing)
                {
                    if (doorLeft_1.Right < mainElevator.Width + doorMaxOpenWidth / 2 + 65)
                    {
                        doorLeft_1.Left += doorSpeed;
                        doorRight_1.Left -= doorSpeed;

                        pictureBox4.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox5.Visible = false;
                    }
                    else
                    {
                        doorTimer.Stop();

                        pictureBox4.Visible = true;
                        pictureBox3.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox5.Visible = false;
                    }
                }
            }
        }



        private void btn_Delete_Click(object sender, EventArgs e) //Deletion
        {
         db_Context.DeleteAllLogs(dt, dataGridView);
        }


        private void groundFloor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
