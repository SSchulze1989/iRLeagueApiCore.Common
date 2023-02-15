namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PostChampSeasonModel
{
    [DataMember]
    public StandingConfigModel? StandingConfig { get; set; }
    [DataMember]
    public IList<ResultConfigModel> ResultConfigs { get; set; } = new List<ResultConfigModel>();
}