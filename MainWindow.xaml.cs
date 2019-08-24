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
using System.IO;
using Microsoft.Win32;

namespace investigacion_dsp_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> items = new List<User>
            {
                new User() { Nombre = "Juan Perez", Telefono = 77777777, Mail = "juan.perez@freemanacademy.com" },
                new User() { Nombre = "Mario Garcia", Telefono = 77777777, Mail = "mario.garcia@freemanacademy.com" },
                new User() { Nombre = "Griffith Pedroza", Telefono = 77777777, Mail = "griffith.pedroza@freemanacademy.com" }
            };
            empleados.ItemsSource = items;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            treeView1.ItemsSource = TreeViewModel.SetTree("Idiomas ofertados");
        }

        private void BtnOpenFile_Clic(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) { }

        }

        public class User
        {
            public string Nombre { get; set; }

            public int Telefono { get; set; }

            public string Mail { get; set; }
        }
    }
}
