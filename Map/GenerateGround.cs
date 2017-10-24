using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map
{
    class GenerateGround : IGenerateGround
    {

        private Pipe pipe;
        private Pipe PipeClone;

        public GenerateGround(Pipe newPipe)
        {
            pipe = newPipe;
            PipeClone = null;
        }

        public Pipe clonePipe()
        {
       
            PipeClone = pipe.clonePipe();
            Console.WriteLine("Use pipe clone");
            return PipeClone;

        }

        public void GeneretaGround()
        {
            Pipe pipebase = clonePipe();
            Console.WriteLine("Map ground generating completed");
        }


       
    }
}
