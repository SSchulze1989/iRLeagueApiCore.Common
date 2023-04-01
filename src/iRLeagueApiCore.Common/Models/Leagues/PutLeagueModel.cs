namespace iRLeagueApiCore.Common.Models;

/// <summary>
/// Schema for posting a new league
/// </summary>
[DataContract]
public class PutLeagueModel
{
    /// <summary>
    /// Full name of the league can contain any UTF-8 characters
    /// </summary>
    [DataMember]
    public string NameFull { get; set; } = string.Empty;
    [DataMember]
    public bool EnableProtests { get; set; }
    /// <summary>
    /// Time span after a race has finished (according to event duration) after which a protest can be filed
    /// </summary>
    [DataMember]
    public TimeSpan ProtestCoolDownPeriod { get; set; }
    /// <summary>
    /// Time span after a race has finished (according to event duration) until a protest can be filed
    /// </summary>
    [DataMember]
    public TimeSpan ProtestsClosedAfter { get; set; }
    /// <summary>
    /// Set public visibility of protests
    /// </summary>
    [DataMember]
    public ProtestPublicSetting ProtestsPublic { get; set; }
    [DataMember]
    public LeaguePublicSetting LeaguePublic { get; set; }   
}
