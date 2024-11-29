using Lift_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift_Project
{
    internal class Lift
    {
        public elevator_state _CurrentState;

        public PictureBox MainElevator;
        public Button Btn_1;
        public Button Btn_G;
        public int FormSize;
        public int LiftSpeed;
        public Timer LiftTimerUp;
        public Timer LiftTimerDown;
        public PictureBox fFloorBack;
        public PictureBox gFloorBack;
        public Timer doorTimer;
        public PictureBox pictureBox1;
        public int CurrentFloor { get; private set; }
        //  private int currentFloor = 0; 

        public Lift(PictureBox mainElevator, Button btn_1, Button btn_G, int formSize, int liftSpeed, Timer liftTimerUp, Timer liftTimerDown, PictureBox ffloorback, PictureBox gFloorBack, Timer doorTimer, PictureBox pictureBox1)
        {
            MainElevator = mainElevator;
            Btn_1 = btn_1;
            Btn_G = btn_G;
            FormSize = formSize;
            LiftSpeed = liftSpeed;
            LiftTimerUp = liftTimerUp;
            LiftTimerDown = liftTimerDown;
            fFloorBack = ffloorback;

            _CurrentState = new IdleState();
            this.gFloorBack = gFloorBack;
            this.doorTimer = doorTimer;
            pictureBox1 = pictureBox1;
        }

        public void SetState(elevator_state state)
        {
            _CurrentState = state;
        }

        public void MovingUp()
        {
            _CurrentState.MovingUp(this);
        }

        public void MovingDown()
        {
            _CurrentState.MovingDown(this);
        }


    }
}
