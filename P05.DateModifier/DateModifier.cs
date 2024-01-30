using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.DateModifier;

public class DateModifier
{
    private int differenceInDays;
    private DateTime firstDate;
    private DateTime lastDate;

    public DateModifier(string firstDate, string lastDate)
    {
        this.firstDate = DateTime.Parse(firstDate);
        this.lastDate = DateTime.Parse(lastDate);
    }
    public int DifferenceInDays
    {
        get
        {
            return differenceInDays = Math.Abs((int)(firstDate - lastDate).TotalDays);
        }
    }
}
