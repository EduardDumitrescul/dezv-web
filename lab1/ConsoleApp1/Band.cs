using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Band: BandInterface
    {
        String name { get; set; }
        int yearFounded { get; set; }

        public Band(String name, int yearFounded)
        {
            this.name = name;   
            this.yearFounded = yearFounded;
        }

        public String getInfo()
        {
            return name + " - " + yearFounded.ToString();
        }

    }
}
