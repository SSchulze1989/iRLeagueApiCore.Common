namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PostProtestModel
{
    [DataMember]
    public long ProtestId { get; set; }
    [DataMember]
    public string AuthorName { get; set; } = string.Empty;
    [DataMember]
    public string ConfirmIRacingId { get; set; } = string.Empty;
    [DataMember]
    public long EventId { get; set; }
    [DataMember]
    public int SessionNr { get; set; }
    [DataMember]
    public string FullDescription { get; set; } = string.Empty;
    [DataMember]
    public string OnLap { get; set; } = string.Empty;
    [DataMember]
    public string Corner { get; set; } = string.Empty;
    [DataMember]
    public ICollection<long> InvolvedMemberIds { get; set; } = new List<long>();
}
