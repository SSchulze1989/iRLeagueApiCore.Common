namespace iRLeagueApiCore.Common.Models.Reviews;

[DataContract]
public sealed class ReviewPenaltyModel
{
    [DataMember]
    public long ResultRowId { get; set; }
    [DataMember]
    public long ReviewId { get; set; }
    [DataMember]
    public long ReviewVoteId { get; set; }
    [DataMember]
    public PenaltyType Type { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int Points { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public TimeSpan Time { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int Positions { get; set; }
}
