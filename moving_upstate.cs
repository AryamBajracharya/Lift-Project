using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift_Project
{
    internal class MovingUpState : elevator_state
    {
        public void MovingDown(Lift lift)
        {
        }

        public void MovingUp(Lift lift)
        {
            if (lift.MainElevator.Location.Y != lift.fFloorBack.Location.Y)
            {
                
                lift.MainElevator.Top -= lift.LiftSpeed;
            }
            else
            {
                lift.SetState(new IdleState());
                lift.MainElevator.Top = lift.fFloorBack.Location.Y;
                Form1 f1 = new Form1(true);
                lift.doorTimer.Start();
                lift.Btn_G.BackColor = Color.White;
                lift.LiftTimerUp.Stop(); 
                lift.Btn_G.Enabled = true; 
                lift.Btn_1.Enabled = true;
            }
        }
    }

}

