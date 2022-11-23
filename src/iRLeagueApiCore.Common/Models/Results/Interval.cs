namespace iRLeagueApiCore.Common.Models;

[DataContract]
public struct Interval
{
    [DataMember]
    public TimeSpan Time { get; set; }
    [DataMember]
    public int Laps { get; set; }
}
