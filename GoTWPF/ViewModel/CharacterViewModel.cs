using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoTWPF.Entities;

namespace GoTWPF.ViewModel
{
    class CharacterViewModel : ViewModelBase
    {
        private Character _character;

        public Character Character
        {
            get { return _character; }
            private set { _character = value; }
        }

        public CharacterViewModel()
        {
            _character = new Character();
        }

        public CharacterViewModel(Character characterModel)
        {
            _character = characterModel;
        }

        #region "Propriétés accessibles, mappables par la View"

        public string FirstName
        {
            get { return _character.FirstName; }
            set
            {
                if (value == _character.FirstName) return;
                _character.FirstName = value;
                base.OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _character.LastName; }
            set
            {
                if (value == _character.LastName) return;
                _character.LastName = value;
                base.OnPropertyChanged("LastName");
            }
        }

        public int Bravoury
        {
            get { return _character.Bravoury; }
            set
            {
                if (value == _character.Bravoury) return;
                _character.Bravoury = value;
                base.OnPropertyChanged("Bravoury");
            }
        }

        public int Crazyness
        {
            get { return _character.Crazyness; }
            set
            {
                if (value == _character.Crazyness) return;
                _character.Crazyness = value;
                base.OnPropertyChanged("Crazyness");
            }
        }

        public int Pv
        {
            get { return _character.Pv; }
            set
            {
                if (value == _character.Pv) return;
                _character.Pv = value;
                base.OnPropertyChanged("Pv");
            }
        }
        #endregion
    }
}
