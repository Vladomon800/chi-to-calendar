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
using CalendarLib;

namespace calendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            app.InsertCalendar += App_InsertCalendar;
        }

        private void App_InsertCalendar(Calendar<Activity> calendar)
        {
            AddCalendar(calendar);
        }

        private void SettingsImageMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            settings_listbox.Visibility = Visibility.Visible;
        }

        ViewAndColor vac = new ViewAndColor();
        private void ViewAndColorListBoxItemSelected(object sender, RoutedEventArgs e)
        {
            settings_listbox.Visibility = Visibility.Hidden;
            vac.ShowDialog();
        }

        private void CreateCalendar_Click(object sender, RoutedEventArgs e)
        {
            CreateCalendarWindow createCalendarWindow = new CreateCalendarWindow();
            createCalendarWindow.ShowDialog();
        }

        CalendarLib.Application app = CalendarLib.Application.GetApplication();
        private void CalendarViewDay_Selected(object sender, RoutedEventArgs e)
        {
            app.Settings.CalendarView = CalendarViews.Day;
            OneDayCalendarView.Visibility = Visibility.Visible;
        }

        private void CalendarViewMonth_Selected(object sender, RoutedEventArgs e)
        {
            app.Settings.CalendarView = CalendarViews.Month;
            OneDayCalendarView.Visibility = Visibility.Hidden;
        }

        private void CalendarViewWeek_Selected(object sender, RoutedEventArgs e)
        {
            app.Settings.CalendarView = CalendarViews.Week;
            OneDayCalendarView.Visibility = Visibility.Hidden;
        }

        private void CalendarViewYear_Selected(object sender, RoutedEventArgs e)
        {
            app.Settings.CalendarView = CalendarViews.Year;
            OneDayCalendarView.Visibility = Visibility.Hidden;
        }

        private void CalendarViewTable_Selected(object sender, RoutedEventArgs e)
        {
            app.Settings.CalendarView = CalendarViews.Table;
            OneDayCalendarView.Visibility = Visibility.Hidden;
        }

        private void CalendarView4Days_Selected(object sender, RoutedEventArgs e)
        {
            app.Settings.CalendarView = CalendarViews.FourDays;
            OneDayCalendarView.Visibility = Visibility.Hidden;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            App.Current.Shutdown();
        }

        private void AddCalendar(Calendar<Activity> calendar)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Tag = calendar;
            checkBox.Content = calendar.Title;
            checkBox.IsChecked = calendar.Visible;
            checkBox.Checked += Activity_CheckBox_Checked;
            Calendars.Items.Add(checkBox);
        }


        private void AddCalendar(Calendar<CalendarLib.Task> calendar)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Tag = calendar;
            checkBox.Content = calendar.Title;
            checkBox.IsChecked = calendar.Visible;
            checkBox.Checked += Task_CheckBox_Checked;
            Calendars.Items.Add(checkBox);
        }

        private void AddCalendar(Calendar<Reminder> calendar)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Tag = calendar;
            checkBox.Content = calendar.Title;
            checkBox.IsChecked = calendar.Visible;
            checkBox.Checked += Reminder_CheckBox_Checked;
            Calendars.Items.Add(checkBox);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var calendar in app.GetCalendarsWithActivities())
                AddCalendar(calendar);

            foreach (var calendar in app.GetCalendarsWithTasks())
                AddCalendar(calendar);

            AddCalendar(app.GetCalendarWithReminders());
        }



        private void Activity_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox CB = sender as CheckBox;
            Calendar<Activity> calendar = (Calendar<Activity>)CB.Tag;
            calendar.Visible = CB.IsChecked ?? false;
        }

        private void Task_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox CB1 = sender as CheckBox;
            Calendar<CalendarLib.Task> calendar = (Calendar<CalendarLib.Task>)CB1.Tag;
            calendar.Visible = CB1.IsChecked ?? false;
        }

        private void Reminder_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox CB2 = sender as CheckBox;
            Calendar<Reminder> calendar = (Calendar<Reminder>)CB2.Tag;
            calendar.Visible = CB2.IsChecked ?? false;
        }

        private void GoToToday(object sender, RoutedEventArgs e)
        {
            app.GoToToday();
        }
    }
}
