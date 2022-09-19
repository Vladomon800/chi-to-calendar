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
using System.Windows.Shapes;
using CalendarLib;

namespace calendar
{
    /// <summary>
    /// Логика взаимодействия для ViewAndColor.xaml
    /// </summary>
    public partial class ViewAndColor : Window
    {
        public ViewAndColor()
        {
            InitializeComponent();
        }

        CalendarLib.Application app = CalendarLib.Application.GetApplication();
        private void ButtonDoneClick(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void ComboBoxColorSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            app.Settings.Color = (CalendarLib.Color)ColorComboBox.SelectedIndex;
        }

        private void ComboBoxViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            app.Settings.View = (View)ViewComboBox.SelectedIndex;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ColorComboBox.SelectedIndex = (int)app.Settings.Color;
            ViewComboBox.SelectedIndex = (int)app.Settings.View;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
