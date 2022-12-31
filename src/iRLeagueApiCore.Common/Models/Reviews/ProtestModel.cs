namespace iRLeagueApiCore.Common.Models;

[DataContract]
public sealed class ProtestModel : PutProtestModel
{
    [DataMember]
    public MemberInfoModel Author { get; set; } = new();
    [DataMember]
    public long ProtestId { get; set; }
    [DataMember]
    public long EventId { get; set; }
    [DataMember]
    public long SessionId { get; set; }
    [DataMember]
    public int SessionNr { get; set; }
}
