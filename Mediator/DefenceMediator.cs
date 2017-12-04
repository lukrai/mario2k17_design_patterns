using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class DefenceMediator : IDefenceMediator
    {
        List<Building> towers = new List<Building>();
        public void AddBuildng(Building building)
        {
            towers.Add(building);
        }

        public void SendShootSignal(string signal)
        {
            foreach(Building building in towers){
				building.Shoot(signal);
			}
		}
        
    }
}