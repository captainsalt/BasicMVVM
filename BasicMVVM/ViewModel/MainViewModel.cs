using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicMVVM.Model;
using System.Windows.Input;
using BasicMVVM.Commands;
using System.Collections.ObjectModel;

namespace BasicMVVM.ViewModel
{
    class MainViewModel : Observable
    {
        string _firstname;
        string _lastname;
        Person _selectedPerson;
        ObservableCollection<Person> _people;

        public ICommand AddNewPersonCommand { get => new RelayCommand(AddNewPerson); }
        public ICommand DeletePersonCommand { get => new RelayCommand(DeletePerson); }
        public string FirstName
        {
            get => _firstname;

            set
            {
                _firstname = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => _lastname;

            set
            {
                _lastname = value;
                OnPropertyChanged();
            }
        }
        public Person SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Person> People
        {
            get => _people;
            set
            {
                _people = value;
                OnPropertyChanged();
            }
        }

        private void AddNewPerson()
        {
            if (People == null)
                People = new ObservableCollection<Person>();

            if (FirstName == null || LastName == null)
            {
                FirstName = "N/A";
                LastName = "N/A";
            }


            People.Add(new Person { FirstName = FirstName, LastName = LastName });
            FirstName = null;
            LastName = null;
        }

        private void DeletePerson()
        {
            if (People == null || People == null)
                return;

            People.Remove(SelectedPerson);
        }
    }
}
