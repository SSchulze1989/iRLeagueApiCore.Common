namespace iRLeagueApiCore.Common.Models;

[DataContract]
public sealed class ProtestModel : PutProtestModel
{
    [DataMember]
    public long ProtestId { get; set; }
    [DataMember]
    public long EventId { get; set; }
    [DataMember]
    public long SessionId { get; set; }
    [DataMember]
    public int SessionNr { get; set; }
    [IgnoreDataMember]
    public new string ConfirmIRacingId { get; set; } = string.Empty;
}
