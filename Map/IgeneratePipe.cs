using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map
{
    interface IgeneratePipe
    {
        Pipe generatePipe();
        void generateDongion();
        void generateExit();
        void generatePrizes();
    }
}
