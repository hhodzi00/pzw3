using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using WPF3.Model;
using System.Collections.ObjectModel;

namespace WPF3.ViewModel
{
    class PersonViewModel : INotifyPropertyChanged
    {
        public PersonViewModel()
        {
            this.Persons = new ObservableCollection<Person>()
            {
                new Person ("ivica", "zurich"),
                new Person ("ivicae", "zuriu"),
                new Person ("ivicaw", "zure"),

            };

            this.SelectedPerson = this.Persons.First();
            this.CommandAddPerson  = new CommandAddPerson(this);
        }

        public CommandAddPerson CommandAddPerson { get; set; }



        public ObservableCollection<Person> Persons { get; set;}




        private Person selectedPerson;
        public Person SelectedPerson
        {
            get { return this.selectedPerson; }

            set
            {
                this.selectedPerson = value;
                RaisePropertyChanged("SelectedPerson");
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        { 
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged
                 (
                    this,
                    new PropertyChangedEventArgs (propertyName)
                 );
            }
        }


        public void AddNewPerson()
        {
            this.Persons.Add(new Person("??", "??"));
        }
    }
}
