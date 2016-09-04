﻿using projektFeladat_WPF.ViewModels;
using System;
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

namespace projektFeladat_WPF.UserControls
{
    /// <summary>
    /// Interaction logic for MessagesUserControl.xaml
    /// </summary>
    public partial class MessagesUserControl : UserControl
    {
        MessagesControlViewModel VM;
        public MessagesUserControl()
        {
            InitializeComponent();
            VM = new MessagesControlViewModel();
            DataContext = VM;
        }
    }
}
