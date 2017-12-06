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

            Console.WriteLine("Placing MysteryBox");

            MysteryBoxFactory factor = new MysteryBoxFactory();

            MysteryBox box1 = factor.GetBox();
            MysteryBox box2 = factor.GetBox();
            MysteryBox box3 = factor.GetBox();
            MysteryBox box4 = factor.GetBox();
            MysteryBox box5 = factor.GetBox();
            MysteryBox box6 = factor.GetBox();
            MysteryBox box7 = factor.GetBox();

            if(box1.getId() != -1)
            {
                Console.WriteLine("MyxteryBox ID: " + box1.getId());
            }
            else
            {
                Console.WriteLine("Invalid MysteryBox id return code: " + box1.getId());
            }

            if (box2.getId() != -1)
            {
                Console.WriteLine("MyxteryBox ID: " + box2.getId());
            }
            else
            {
                Console.WriteLine("Invalid MysteryBox id return code: " + box2.getId());
            }

            if (box3.getId() != -1)
            {
                Console.WriteLine("MyxteryBox ID: " + box3.getId());
            }
            else
            {
                Console.WriteLine("Invalid MysteryBox id return code: " + box3.getId());
            }

            if (box4.getId() != -1)
            {
                Console.WriteLine("MyxteryBox ID: " + box4.getId());
            }
            else
            {
                Console.WriteLine("Invalid MysteryBox id return code: " + box4.getId());
            }

            if (box5.getId() != -1)
            {
                Console.WriteLine("MyxteryBox ID: " + box5.getId());
            }
            else
            {
                Console.WriteLine("Invalid MysteryBox id return code: " + box5.getId());
            }

            if (box6.getId() != -1)
            {
                Console.WriteLine("MyxteryBox ID: " + box6.getId());
            }
            else
            {
                Console.WriteLine("Invalid MysteryBox id return code: " + box6.getId());
            }

            if (box7.getId() != -1)
            {
                Console.WriteLine("MyxteryBox ID: " + box7.getId());
            }
            else
            {
                Console.WriteLine("Invalid MysteryBox id return code: " + box7.getId());
            }

            Console.WriteLine("Finised placing  MysteryBox");

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
