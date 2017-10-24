using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17.Map
{
    class Pipe : IPipeCopy
    {
        private int ID;

        public Pipe(int id) { ID = id; }

        public Pipe clonePipe()
        {
            Console.WriteLine("Returned Pipe clone");
            return new Pipe(ID++);
        }

        public int returnPipeId()
        {
            return ID;
        }
    }
}
