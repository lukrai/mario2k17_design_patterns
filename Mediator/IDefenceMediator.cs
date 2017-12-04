using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public interface IDefenceMediator
    {
        void AddBuildng(Building building);

        void SendShootSignal(string signal);
    }
}