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

namespace Caravans
{
    /// <summary>
    /// Логика взаимодействия для Errors.xaml
    /// </summary>
    public partial class Errors : Window
    {
        public Errors()
        {
            InitializeComponent();
        }

        private void Exiterror_Click(object sender, RoutedEventArgs e) => Close();


    }
}