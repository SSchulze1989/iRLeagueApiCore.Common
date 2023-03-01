﻿namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PutChampSeasonModel : PostChampSeasonModel
{
    [DataMember]
    public string ChampionshipName { get; set; } = string.Empty;
    [DataMember]
    public string ChampionshipDisplayName { get; set; } = string.Empty;
    [DataMember]
    public StandingConfigModel? StandingConfig { get; set; }
    [DataMember]
    public ICollection<ResultConfigInfoModel> ResultConfigs { get; set; } = new List<ResultConfigInfoModel>();
}