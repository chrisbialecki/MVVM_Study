using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVM_Study_1.Model
{
    public class Student : INotifyPropertyChanged
    {

        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnProperyChanged("FirstName");
                OnProperyChanged("FullName");
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnProperyChanged("LastName");
                OnProperyChanged("FullName");
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName;  }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        

        void OnProperyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }


    }
}
