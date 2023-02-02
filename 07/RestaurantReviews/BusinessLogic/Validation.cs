using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    /// <summary>
    /// This is the class to validate iunput from UI or outout from Data Layer
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// Handles nullable time coming from Data layer
        /// </summary>
        /// <param name="time"></param>
        /// <returns>Zero if time is null or else the value of the time</returns>
        public static TimeSpan HandleTimeSpanNulls(TimeSpan? time)
        {
            if(time.HasValue)
                return time.Value;
            return TimeSpan.Zero;
        }
        /// <summary>
        /// This method will try to convert input string to Time provided the input string is in the form of HH:mm:ss
        /// </summary>
        /// <param name="strTime"></param>
        /// <returns></returns>
        public static TimeSpan StringToTime(string strTime)
        {
            TimeSpan time = TimeSpan.Zero;
            if (TimeSpan.TryParse(strTime, out time))// out keyword is used for call by reference just like ref keyword but the difference is that out variable type has to be initialized
                return time;
            return TimeSpan.Zero;
        }

        // code for phone validation

        // code for email here

        // code for website

    }
}
