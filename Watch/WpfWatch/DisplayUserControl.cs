using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfWatch
{
    public class DisplayUserControl : UserControl
    {
        public bool Backlight
        {
            get { return (bool)GetValue(BacklightProperty); }
            set { SetValue(BacklightProperty, value); }
        }
        public static readonly DependencyProperty BacklightProperty =
            DependencyProperty.Register("Backlight", typeof(bool), typeof(DisplayUserControl), new FrameworkPropertyMetadata(false, ColorPropertyChanged));

        public static void ColorPropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            DisplayUserControl display = sender as DisplayUserControl;
            display.SetColorProperty((bool)e.NewValue);
        }
        public virtual void SetColorProperty(bool bulb)
        {
            Background = bulb ? Brushes.DarkBlue : Brushes.Black;
        }
    }
}
