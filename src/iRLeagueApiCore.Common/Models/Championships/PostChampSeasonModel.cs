namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PostChampSeasonModel
{
    [DataMember]
    public long? StandingConfigId { get; set; }
    [DataMember]
    public ICollection<long> ResultConfigIds { get; set; } = new List<long>();
}