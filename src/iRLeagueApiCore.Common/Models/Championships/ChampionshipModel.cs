namespace iRLeagueApiCore.Common.Models.Championships;

[DataContract]
public sealed class ChampionshipModel : PutChampionshipModel
{
    [DataMember]
    public long ChampionshipId { get; set; }
    [DataMember]
    public IEnumerable<ChampSeasonModel> Seasons { get; set; } = Array.Empty<ChampSeasonModel>();
}
