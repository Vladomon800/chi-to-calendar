using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для CreateCalendarWindow.xaml
    /// </summary>
    public partial class CreateCalendarWindow : Window
    {
        public CreateCalendarWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// При загрузке окна добавляется коллекция всех часовых поясов в ComboBox(timeZones)
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in TimeZoneInfo.GetSystemTimeZones())
            {
                timeZones.Items.Add(item);
            }

            timeZones.SelectedValue = TimeZoneInfo.Local;
        }

        /// <summary>
        /// Сохранения календаря в массив календарей по нажатию на кнопку 
        /// </summary>
        private void SaveCalendar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ActivityCalendar calendar = new ActivityCalendar(title.Text.ToString())
                {
                    Description = description.Text.ToString(),
                    TimeZone = timeZones.SelectedItem as TimeZoneInfo
                };
                CalendarLib.Application.GetApplication().AddCalendar(calendar);
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Говно, переделывай", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
