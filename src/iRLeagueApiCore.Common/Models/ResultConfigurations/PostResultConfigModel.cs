﻿namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PostResultConfigModel
{
    [DataMember]
    public string Name { get; set; } = string.Empty;
    [DataMember]
    public string DisplayName { get; set; } = string.Empty;
    [DataMember]
    public ResultKind ResultKind { get; set; }
    [DataMember]
    public ResultConfigInfoModel? SourceResultConfig { get; set; }
    [DataMember]
    public ICollection<ScoringModel> Scorings { get; set; } = new List<ScoringModel>();
    [DataMember]
    public ICollection<ResultFilterModel> FiltersForPoints { get; set; } = new List<ResultFilterModel>();
    [DataMember]
    public ICollection<ResultFilterModel> FiltersForResult { get; set; } = new List<ResultFilterModel>();
}
