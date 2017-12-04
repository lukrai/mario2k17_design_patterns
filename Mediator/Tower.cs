
using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class Tower : Building
    {
        // Constructor
        public Tower(IDefenceMediator mediator)
            : base(mediator)
        {

        }
    
        public override void SendSignal(string signal)
        {
            mediator.SendShootSignal(signal);
        }
    
        public override void Shoot(string signal)
        {
            Console.WriteLine("Tower gets signal: "
            + signal + " Starting to shoot!");
        }
    }
}