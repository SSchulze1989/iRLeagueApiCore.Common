﻿namespace iRLeagueApiCore.Common.Models;

[DataContract]
public sealed class PenaltyModel : PutPenaltyModel
{
    [DataMember]
    public long ResultRowId { get; set; }
    [DataMember]
    public long? AddPenaltyId { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public long? ReviewId { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public long? ReviewVoteId { get; set; }
    [DataMember]
    public long EventId { get; set; }
    [DataMember]
    public long? SessionId { get; set; }
    [DataMember]
    public string SessionName { get; set; } = string.Empty;
    [DataMember]
    public long MemberId { get; set; }
    [DataMember]
    public string Firstname { get; set; } = string.Empty;
    [DataMember]
    public string Lastname { get; set; } = string.Empty;
}
