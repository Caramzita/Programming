using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private Contact _currentContact = new Contact();

        public event PropertyChangedEventHandler PropertyChanged;

        private SaveCommand saveCommand;

        public SaveCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new SaveCommand(obj =>
                  {
                      ContactSerializer.SaveData(CurrentContact);
                  }));
            }
        }

        private LoadCommand loadCommand;

        public LoadCommand LoadCommand
        {
            get
            {
                return loadCommand ??
                  (loadCommand = new LoadCommand(obj =>
                  {
                      CurrentContact = ContactSerializer.LoadDataFromFile();
                  }));
            }
        }

        public string Name
        {
            get
            {
                return _currentContact.Name;
            }
            set
            {
                _currentContact.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _currentContact.PhoneNumber;
            }
            set
            {
                _currentContact.PhoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public string Email
        {
            get
            {
                return _currentContact.Email;
            }
            set
            {
                _currentContact.Email = value;
                OnPropertyChanged("Email");
            }
        } 
        
        public Contact CurrentContact
        {
            get
            {
                return _currentContact;
            }
            set
            {
                _currentContact = value;
                OnPropertyChanged("CurrentContact");
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }   
}
