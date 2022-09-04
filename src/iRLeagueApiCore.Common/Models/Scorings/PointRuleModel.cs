using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Scorings
{
    [DataContract]
    public class PointRuleModel : PutPointRuleModel
    {
        [DataMember]
        public long LeagueId { get; set; }
        [DataMember]
        public long PointRuleId { get; set; }
    }
}
