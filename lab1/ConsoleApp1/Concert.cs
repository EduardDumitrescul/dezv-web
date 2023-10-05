using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Concert: ConcertInterface
    { 
        String name
        {
            get; set;
        }

        String date { get; set; }
        int startTime { get; set; }
        int endTime { get; set; }

        public List<Band> bands { get; private set; }


        public Concert(String name, String date, int startTime, int endTime, List<Band> bands)
        {
            this.name = name;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime; 
            this.bands = bands;
        }

        public String getInfo()
        {
            return this.name + " - " + this.date;
        }
    }
}
