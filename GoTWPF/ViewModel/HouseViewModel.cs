using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoTWPF.Entities;


namespace GoTWPF.ViewModel
{
    class HouseViewModel : ViewModelBase
    {
        private House _house;

        public House House
        {
            get { return _house; }
            private set { _house = value; }
        }

        public HouseViewModel()
        {
            _house = new House();
        }

        public HouseViewModel(House houseModel)
        {
            _house = houseModel;
        }

        public string Name
        {
            get { return _house.Name; }
            set
            {
                if (value == _house.Name) return;
                _house.Name = value;
                base.OnPropertyChanged("Name");
            }
        }

        public int NumberOfUnities
        {
            get { return _house.NumberOfUnities; }
            set
            {
                if (value == _house.NumberOfUnities) return;
                _house.NumberOfUnities = value;
                base.OnPropertyChanged("NumberOfUnities");
            }
        }

    }
}
