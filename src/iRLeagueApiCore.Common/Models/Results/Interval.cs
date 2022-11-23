namespace iRLeagueApiCore.Common.Models;

[DataContract]
public struct Interval
{
    public Interval()
    {
        Time = TimeSpan.Zero;
        Laps = 0;
    }

    public Interval(TimeSpan interval)
    {
        Time = interval.Subtract(TimeSpan.FromDays(interval.Days));
        Laps = interval.Days;
    }

    [DataMember]
    public TimeSpan Time { get; set; }
    [DataMember]
    public int Laps { get; set; }
}
