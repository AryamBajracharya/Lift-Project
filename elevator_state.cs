using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Two methods Moving Up and Down
namespace Lift_Project
{
    internal interface elevator_state 
    {

        void MovingUp(Lift lift);
        void MovingDown(Lift lift);
    }
}
