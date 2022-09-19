using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarLib
{
    public class Calendar<T> where T : Event
    {
        public bool Visible;
        public string Title;

        protected List<T> events = new List<T>();

        public Calendar(string name)
        {
            Title = name;
            if (Title == "")
                throw new Exception("������ ���������");
        }

        public void AddEvent(T @event)
        {
            events.Add(@event);
        }

        /// <summary>
        /// ���������� ������ �������, ������� ���������� � ��������� ����
        /// </summary>
        /// <param name="date">���� ��� ����������</param>
        /// <returns>������ �������</returns>
        public virtual T[] GetEventsByDate(DateTime start, DateTime? end = null)
        {
            return events.Where(e => start.Date == e.StartDateTime.Date).ToArray();
        }

        public T[] GetActivitisByDay(DateTime date)
        {
            return events.Where(e => date.Date >= (e as Activity).StartDateTime.Date && date.Date <= (e as Activity).EndDateTime.Date).ToArray();
        }
    }
}
