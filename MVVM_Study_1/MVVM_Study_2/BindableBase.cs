﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Study_2
{
    public class BindableBase : INotifyPropertyChanged
    {
        protected virtual void SetProperty<T>(ref T member, T val, [CallerMemberName] string propertyName = null)
        {

            if (member != null)
            {
                MessageBox.Show("in SetProperty. \nExisting view: " + member.ToString() + "\nNew view: " + val.ToString());
            }
            if(member == null)
            { MessageBox.Show("member is null"); }
            
            if (object.Equals(member, val)) return;

            member = val;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

           
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        
        
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
