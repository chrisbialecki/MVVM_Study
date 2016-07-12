
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Study_1.Model;

namespace MVVM_Study_1.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
          get;
          set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> _students = new ObservableCollection<Student>();
            _students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            _students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            _students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });

            Students = _students;
        }


    }
}
