namespace iRLeagueApiCore.Common.Models.Results;

[DataContract]
public sealed class AddBonusModel : PutAddBonusModel
{
    [DataMember]
    public long AddBonusId { get; set; }
    [DataMember]
    public long ResultRowId { get; set; }
    [DataMember]
    public long EventId { get; set; }
    [DataMember]
    public int SessionNr { get; set; }
    [DataMember]
    public string SessionName { get; set; } = string.Empty;
    [DataMember]
    public MemberInfoModel? Member { get; set; }
    [DataMember]
    public TeamInfoModel? Team { get; set; }
}
