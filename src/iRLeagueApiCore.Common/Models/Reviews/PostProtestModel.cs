namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class PostProtestModel
{
    [DataMember]
    public string AuthorMemberId { get; set; } = string.Empty;
    [DataMember]
    public string ConfirmIRacingId { get; set; } = string.Empty;
    [DataMember]
    public string FullDescription { get; set; } = string.Empty;
    [DataMember]
    public string OnLap { get; set; } = string.Empty;
    [DataMember]
    public string Corner { get; set; } = string.Empty;
    [DataMember]
    public ICollection<long> InvolvedMemberIds { get; set; } = new List<long>();
}
