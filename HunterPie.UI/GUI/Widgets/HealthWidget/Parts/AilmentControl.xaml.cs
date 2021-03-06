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

namespace HunterPie.GUI.Widgets.HealthWidget.Parts
{
    /// <summary>
    /// Interaction logic for AilmentControl.xaml
    /// </summary>
    public partial class AilmentControl : UserControl
    {

        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(ImageSource), typeof(AilmentControl));

        public float TimerEndAngle
        {
            get { return (float)GetValue(TimerEndAngleProperty); }
            set { SetValue(TimerEndAngleProperty, value); }
        }
        public static readonly DependencyProperty TimerEndAngleProperty =
            DependencyProperty.Register("TimerEndAngle", typeof(float), typeof(AilmentControl));

        public AilmentControl()
        {
            InitializeComponent();
        }
    }
}
