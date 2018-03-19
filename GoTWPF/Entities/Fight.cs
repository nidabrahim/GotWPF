using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTWPF.Entities
{
    class Fight
    {
        public string HouseChalleging { get; set; }
        public string HouseChalleged { get; set; }
        public string WinningHouse { get; set; }
        public Territory Territory { get; set; }

        public Fight() { }
    }
}
