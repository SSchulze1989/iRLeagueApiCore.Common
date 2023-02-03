namespace iRLeagueApiCore.Common.Models.Championships;

[DataContract]
public sealed class ChampSeasonModel : PutChampSeasonModel
{
    [DataMember]
    public long ChampSeasonId { get; set; }
    [DataMember]
    public long ChampionshipId { get; set; }
    [DataMember]
    public long SeasonId { get; set; }
}