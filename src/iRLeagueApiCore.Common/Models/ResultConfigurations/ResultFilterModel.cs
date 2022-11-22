namespace iRLeagueApiCore.Common.Models;

[DataContract]
public sealed class ResultFilterModel
{
    [DataMember]
    public long ResultsFilterId { get; set; }
    [DataMember]
    public long LeagueId { get; set; }
    [DataMember]
    public string ResultsFilterType { get; set; } = string.Empty;
    [DataMember]
    public string ColumnPropertyName { get; set; } = string.Empty;
    [DataMember]
    public ComparatorType Comparator { get; set; }
    [DataMember]
    public bool Include { get; set; }
    [DataMember]
    public ICollection<string> FilterValues { get; set; } = Array.Empty<string>();
}
