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

namespace UITest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainCanvas.Focus();

            //mainCanvas.Children.Add(); !!!!!
        }

        private void mainCanvas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void mainCanvas_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
