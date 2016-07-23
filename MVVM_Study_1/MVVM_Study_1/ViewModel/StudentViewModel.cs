
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
        //create a command
        public MyICommand DeleteCommand { get; set; }

        //constructor
        public StudentViewModel()
        {
            LoadStudents();
            DeleteCommand = new MyICommand(OnDelete, CanDelete);
        }

        private void OnDelete()
        {
            Students.Remove(SelectedStudent);
        }

        private bool CanDelete()
        {
            return SelectedStudent != null;

        }


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

        private Student _selectedStudent;
        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {

                _selectedStudent = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }


    }
}
