using System;
using System.Collections.Generic;
using System.Text;

namespace Mario2k17
{
    public class GunFactory
    {
        protected string type;
        
        public GunFactory(string t)
        {
            type = t;
        }
        
        public Gun createGun()
        {
            Console.WriteLine(type);
            if (type.Equals("Ak47")){
                return new Ak47();
            }
            else if (type.Equals("Deagle")){
                return new Deagle();
            }
            else {
                return new MachineGun();
            }
        }
    }
}