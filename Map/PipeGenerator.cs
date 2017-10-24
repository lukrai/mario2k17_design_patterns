using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map
{
    class PipeGenerator : IgeneratePipe
    {
        public void generateDongion()
        {
            Console.WriteLine("Generating pipe dongion");
        }

        public void generateExit()
        {
            Console.WriteLine("Generating dongion exit");
        }

        public Pipe generatePipe()
        {
            Pipe newPipe = new Pipe(0);
            Console.WriteLine("Generated pipe class");
            return newPipe;
        }

        public void generatePrizes()
        {
            Console.WriteLine("Generating dongion prizes");
        }
    }
}
