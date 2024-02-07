using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        public static double GetDiff(DateTime startDate, DateTime endTime)
        {
            var resultDiff = Math.Abs((startDate-endTime).TotalDays);
            return resultDiff;
        }
    }
}
