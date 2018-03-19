using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTWPF.Entities
{
    public class House
    {
        private String _name;
        private int _numberOfUnities;
        List<Character> _housers;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int NumberOfUnities
        {
            get { return _numberOfUnities; }
            set { _numberOfUnities = value; }
        }

        public List<Character> Housers
        {
            get { return _housers; }
            set { _housers = value; }
        }


        public House()
        {
        }

        public House(String name, int nbr)
        {
            _name = name;
            _numberOfUnities = nbr;
        }
        
    }
}
