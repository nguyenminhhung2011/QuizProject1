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
using System.Windows.Shapes;

namespace QuizProject1
{
    /// <summary>
    /// Interaction logic for mainStudentForm.xaml
    /// </summary>
    public partial class mainStudentForm : Window
    {
        public mainStudentForm()
        {
            InitializeComponent();
            main_grid.Children.Clear();
            main_grid.Children.Add(new introduce_form());
        }

        private void btn_power_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}