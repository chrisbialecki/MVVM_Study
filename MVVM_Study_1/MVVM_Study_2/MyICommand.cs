using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Study_2
{
    public class MyICommand<T> :  ICommand
    {

        Action<T> _TargetExecuteMethod;
        Func<T, bool> _TargetCanExecuteMethod;


        public MyICommand(Action<T> executeMethod)
        {
            _TargetExecuteMethod = executeMethod;

        }

        public MyICommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            MessageBox.Show("I'm in MyICommand constructor, Action and Func");
            
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
          
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
            MessageBox.Show("can execute changed");
        }

        
        
        bool ICommand.CanExecute(object parameter)
        {          
            
            if (_TargetCanExecuteMethod != null)
            {
                T tparm = (T)parameter;
                return _TargetCanExecuteMethod(tparm);
                
            }          

            if (_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;
        }

        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod((T)parameter);
            }

            MessageBox.Show("In ICommand.Execute.  TargetExecute method: " + _TargetExecuteMethod.Method.ToString() + ", parameter: " + parameter.ToString());
        }



        public event EventHandler CanExecuteChanged = delegate { };

        
    }
}
