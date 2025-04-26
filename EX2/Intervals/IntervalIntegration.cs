using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervals
{
    public class IntervalIntegration
    {

        public List<Interval> Intervals = new();
        public List<Interval> Integration(List<Interval> interval)
        {

            var sortedIntervals = interval.OrderBy(interval => interval.Start).ToList();

            for (int i = 0; i < sortedIntervals.Count; i++)
            {
                if (i + 1 < sortedIntervals.Count)
                {

                    if (sortedIntervals[i].Members.Union(sortedIntervals[i + 1].Members).ToList().SequenceEqual(new Interval { Start = sortedIntervals[i].Start, End = sortedIntervals[i + 1].End }.Members))
                    {
                        sortedIntervals[i] = new Interval { Start = sortedIntervals[i].Start, End = sortedIntervals[i + 1].End };
                        sortedIntervals.RemoveAt(i + 1);
                        i--;
                    }

                }
            }
            return sortedIntervals;
        }

    }
    public record Interval
    {
        public int Start { get; set; }
        public int End { get; set; }
        private List<int> members = new List<int>();
        public List<int> Members
        {
            get
            {
                members = new List<int>();
                for (int i = Start; i <= End; i++)
                {
                    members.Add(i);
                }
                return members;
            }
            set { }
        }
    }
}
