namespace iRLeagueApiCore.Common.Models;

[DataContract]
public sealed class ResultFilterModel
{
    [DataMember]
    public long LeagueId { get; set; }
    [DataMember]
    public long FilterOptionId { get; set; }
    [DataMember]
    public FilterType FilterType { get; set; }
    [DataMember]
    public string ColumnPropertyName { get; set; } = string.Empty;
    [DataMember]
    public ComparatorType Comparator { get; set; }
    /// <summary>
    /// <para>Action performed on values that match the conditions</para>   
    /// <para>- Keep: Keep the entries that match and remove all other entries</para>
    /// <para>- Remove: Remove the entries that match and keep other entries</para>
    /// </summary>
    [DataMember]
    public MatchedValueAction Action { get; set; }
    [DataMember]
    public ICollection<string> FilterValues { get; set; } = Array.Empty<string>();
}
