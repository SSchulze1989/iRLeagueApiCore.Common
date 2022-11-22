namespace iRLeagueApiCore.Common.Models;

[DataContract]
public class ResultConfigModel : PutResultConfigModel
{
    [DataMember]
    public long LeagueId { get; set; }
    [DataMember]
    public long ResultConfigId { get; set; }
}
