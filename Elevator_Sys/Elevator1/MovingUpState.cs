﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator1
{
    internal class MovingUpStateConcreteClass : ILiftState
    {
        public void MovingDown(Lift lift)
        {
        }

        private Form1 form;

        public MovingUpStateConcreteClass(Form1 mainForm)
        {
            form = mainForm;
        }

        public void MovingUp(Lift lift)
        {
            if (lift.Mainelevator.Bottom != lift.Ffloor.Bottom)
            {
                if (!(lift.doorsclosed))
                {
                    lift.SetState(new CloseButtonStateConcreteClass(form));
                    lift.CloseButton();

                    EventHandler doorCloseHandler = null;
                    doorCloseHandler = (s, args) =>
                    {
                        if (lift.doorsclosed)
                        {
                            lift.movingup = true;
                            lift.movingdown = false;
                            lift.Lifttimer.Start();
                            form.logEvents("Lift on First Floor");

                            lift.Doortimer1.Tick -= doorCloseHandler;
                        }
                    };
                    lift.Doortimer1.Tick += doorCloseHandler;
                }
                else
                {
                    lift.movingup = true;
                    lift.movingdown = false;
                    lift.Lifttimer.Start();
                    form.logEvents("Lift on First Floor");
                }


                EventHandler liftMoveHandler = null;
                liftMoveHandler = (s, args) =>
                {
                    if (lift.Mainelevator.Top == lift.Ffloor.Top)
                    {
                        lift.Lifttimer.Stop();
                        lift.SetState(new OpenButtonStateConcreteClass(form));
                        lift.OpenButton();

                        lift.Lifttimer.Tick -= liftMoveHandler;

                        lift.movingup = false;
                        lift.movingdown = false;
                    }
                };
                lift.Lifttimer.Tick += liftMoveHandler;
            }
            else
            {
                lift.Lifttimer.Stop();
                form.logEvents("Lift on first floor");
            }
        }
        public void CloseButton(Lift lift) { }
        public void OpenButton(Lift lift) { }
        public void LiftTimer(Lift lift) { }
        public void DoorTimer1(Lift lift) { }
        public void DoorTimer2(Lift lift) { }
    }
}
