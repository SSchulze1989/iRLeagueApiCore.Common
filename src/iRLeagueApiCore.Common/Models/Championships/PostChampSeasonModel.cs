namespace iRLeagueApiCore.Common.Models.Championships;

[DataContract]
public class PostChampSeasonModel
{
    [DataMember]
    public long StandingConfigId { get; set; }
    [DataMember]
    public ICollection<long> ResultConfigIds { get; set; } = new List<long>();
}