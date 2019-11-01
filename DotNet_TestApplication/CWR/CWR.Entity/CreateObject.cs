using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWR.Entity
{
     public sealed class CreateObject
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="CreateObject"/> class from being created.
        /// </summary>
        private CreateObject()
        {
        }

        /// <summary>
        /// Create an object of T Class
        /// </summary>
        /// <typeparam name="T">Object to be created</typeparam>
        /// <returns>New Object</returns>
        public static T GetObject<T>() where T : new()
        {
            //// return New Object
            return new T();
        }

        public static List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day)) // Map each day to a date
                             .ToList(); // Load dates into a list
        }
    }
}
