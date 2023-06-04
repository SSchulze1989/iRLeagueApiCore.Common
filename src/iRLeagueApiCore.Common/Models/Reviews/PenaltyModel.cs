﻿namespace iRLeagueApiCore.Common.Models;

[DataContract]
public sealed class PenaltyModel
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
    public PenaltyType Type { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int Points { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public TimeSpan Time { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int Positions { get; set; }
}