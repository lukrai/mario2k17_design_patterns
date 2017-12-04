using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public abstract class Building
    {
        protected IDefenceMediator mediator;

        public Building(IDefenceMediator mediator)
        {
            this.mediator = mediator;
        }
        public abstract void SendSignal(string signal);

        public abstract void Shoot(string signal);
    }
}
