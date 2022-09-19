using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLib
{
    public class Application
    {

        public Settings Settings = new Settings();
        private static Application application;

        private Application()
        {
            AddCalendar(new ActivityCalendar("Мероприятия"));
            taskcalendars.Add(new Calendar<Task>("Задачи"));
        }

        /// <summary>
        /// Возваращает единственный экземпляр класса application
        /// </summary>
        /// <returns>Экземпляр класса Application</returns>
        public static Application GetApplication()
        {
            if (application == null) application = new Application();
            return application;
        }

        /// <summary>
        /// календари с мероприятиями
        /// </summary>
        private List<ActivityCalendar> activitycalendars = new List<ActivityCalendar>();
        /// <summary>
        /// календари с задачами
        /// </summary>
        private List<Calendar<Task>> taskcalendars = new List<Calendar<Task>>();
        /// <summary>
        /// Календари с напоминаниями
        /// </summary>
        private Calendar<Reminder> remindercalendars = new Calendar<Reminder>("Напоминания");

        private List<Event> bin = new List<Event>();

        public Event[] Bin
        {
            get;
        }

        /// <summary>
        /// Возвращает все календари в которых есть задачи
        /// </summary>
        /// <returns>Массив календарей</returns>
        public Calendar<Task>[] GetCalendarsWithTasks()
        {
            return taskcalendars.ToArray();
        }

        /// <summary>
        /// Возвращает все календари в которых есть мероприятия
        /// </summary>
        /// <returns>Массив календарей</returns>
        public ActivityCalendar[] GetCalendarsWithActivities()
        {
            return activitycalendars.ToArray();
        }

        

        /// <summary>
        /// Возвращает все календари содержащие напоминания
        /// </summary>
        /// <returns>Массив календарей</returns>
        public Calendar<Reminder> GetCalendarWithReminders()
        {
            return remindercalendars;
        }

        /// <summary>
        /// Создаёт новый календарь
        /// </summary>
        /// <param name="calendar">Календарь с мероприятиями</param>
        /// <returns>Календарь</returns>
        /// <exception cref="Exception"></exception>
        public void AddCalendar(ActivityCalendar calendar)
        {
            activitycalendars.Add(calendar);
            InsertCalendar?.Invoke(calendar);
        }

        public delegate void InsertCalendarDelegate(Calendar<Activity> calendar);
        public event InsertCalendarDelegate InsertCalendar;

        /// <summary>
        /// Изменяет дату выбранного дня на сегодняшнюю дату
        /// </summary>
        /// <returns>Сегодняшняя дата</returns>
        public void GoToToday()
        {
            Settings.ChosenDate = DateTime.Today;
        }
    }
}
