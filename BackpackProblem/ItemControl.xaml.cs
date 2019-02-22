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

namespace BackpackProblem
{
    /// <summary>
    /// Логика взаимодействия для ItemControl.xaml
    /// </summary>
    public partial class ItemControl : UserControl
    {
        public ItemControl()
        {
            InitializeComponent();
        }

        private void bRemoveItem_Click(object sender, RoutedEventArgs e)
        {
            (Parent as ListBox).Items.Remove(this);
        }
    }
}
