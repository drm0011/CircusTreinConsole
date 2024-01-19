using CircusTreinConsole.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CircusTreinConsole
{
    public class Animal
    {
        public Types type { get; set; }
        public string name { get; set; }
        public Sizes size { get; set; }

        public Animal(Types type, string name, Sizes size)
        {
            this.type = type;
            this.name = name;
            this.size = size;
        }

        //return the proper point value for each size
        public int GetPoints()
        {
            switch (size)
            {
                case Sizes.Small:
                    return 1;
                case Sizes.Medium:
                    return 3;
                case Sizes.Large:
                    return 5;
                default:    
                    return 0;
            }
        }
    }
}

