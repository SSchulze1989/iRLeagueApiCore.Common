using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class ResultConfigurationModel : PutResultConfigurationModel
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long LeagueId { get; set; }
        [DataMember]
        public long ResultTabId { get; set; }
    }
}
