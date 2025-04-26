using Intervals;
#region test1
//List<Interval> INTERVALS = new List<Interval> {
//    new Interval{Start=1,End=3},
//    new Interval{Start=2,End=6},
//    new Interval{Start=8,End=10},
//    new Interval{Start=15,End=18},

//};
//IntervalIntegration intervalIntegration = new IntervalIntegration();

//var result = intervalIntegration.Integration(INTERVALS);
//foreach (var x in result)
//{
//    foreach (var y in x.Members)
//    {
//        Console.Write(y.ToString() + ",");
//    }
//    Console.WriteLine("\n#########################");
//}
#endregion
#region test2
List<Interval> INTERVALS = new List<Interval> {
    new Interval{Start=1,End=4},
    new Interval{Start=4,End=5}
};
IntervalIntegration intervalIntegration = new IntervalIntegration();

var result = intervalIntegration.Integration(INTERVALS);
foreach (var x in result)
{
    foreach (var y in x.Members)
    {
        Console.Write(y.ToString() + ",");
    }
    Console.WriteLine("\n#########################");
}
#endregion