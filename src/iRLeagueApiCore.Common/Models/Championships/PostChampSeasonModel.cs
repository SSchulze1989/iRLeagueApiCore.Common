namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PostChampSeasonModel
{
    [DataMember]
    public StandingConfigModel? StandingConfigId { get; set; }
    [DataMember]
    public ICollection<ResultConfigInfoModel> ResultConfigIds { get; set; } = new List<ResultConfigInfoModel>();
}