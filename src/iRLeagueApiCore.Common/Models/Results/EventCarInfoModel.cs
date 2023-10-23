namespace iRLeagueApiCore.Common.Models.Results;

/// <summary>
/// Contains information about a specific car in an event and it's driver(s) or team
/// </summary>
[DataContract]
public sealed class EventCarInfoModel
{
    [DataMember]
    public int Number { get; set; }
    [DataMember] 
    public string Car { get; set; } = string.Empty;
    [DataMember]
    public int CarId { get; set; }
    [DataMember] 
    public int ClassId { get;}
    [DataMember]
    public string Class { get; set; } = string.Empty;
    [DataMember]
    public MemberInfoModel? Member { get; set; }
    [DataMember]
    public TeamInfoModel? Team { get; set; }
}
