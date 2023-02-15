namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PostChampSeasonModel
{
    [DataMember]
    public StandingConfigModel? StandingConfig { get; set; }
    [DataMember]
    public ICollection<ResultConfigInfoModel> ResultConfigs { get; set; } = new List<ResultConfigInfoModel>();
}