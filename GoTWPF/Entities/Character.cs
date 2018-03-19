using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTWPF.Entities
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Bravoury { get; set; }
        public int Crazyness { get; set; }
        public int Pv { get; set; }


        public Character() { }

        public Character(string FirstName, string LastName, int Bravoury, int Crazyness, int Pv)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Bravoury = Bravoury;
            this.Crazyness = Crazyness;
            this.Pv = Pv;
        }
    }
}
