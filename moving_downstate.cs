using Lift_Project;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiftDemo_A
{
    internal class MovingDownState : elevator_state
    {
        public void MovingDown(Lift lift)
        {
            if (lift.MainElevator.Location.Y < lift.gFloorBack.Location.Y)
            {
                
                lift.MainElevator.Top += lift.LiftSpeed ;
            }
            else
            {
                lift.SetState(new IdleState());
                lift.MainElevator.Top = lift.gFloorBack.Location.Y;

                Form1 f1 = new Form1(true);
                lift.doorTimer.Start();
                lift.Btn_1.BackColor = Color.White;
                lift.LiftTimerDown.Stop();  // Stop the timer when it reaches the bottom
                lift.Btn_1.Enabled = true;  // Re-enable the 1st floor button
                lift.Btn_G.Enabled = true;  // Enable other controls
            }
        }

        public void MovingUp(Lift lift)
        {
        }
    }
}
