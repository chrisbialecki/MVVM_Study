﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_Study_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            MVVM_Study_1.ViewModel.StudentViewModel _studentViewModelObject = new ViewModel.StudentViewModel();
            _studentViewModelObject.LoadStudents();

            StudentViewControlXXX.DataContext = _studentViewModelObject;
        }
    }
}
