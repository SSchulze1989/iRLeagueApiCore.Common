using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class ResultTabModel : PutResultTabModel
    {
        [DataMember]
        public long LeagueId { get; set; }
        /// <summary>
        /// Unique id for the result tab
        /// </summary>
        [DataMember]
        public long ResultTabId { get; set; }
        [DataMember]
        public long SeasonId { get; set; }
        [DataMember]
        public long ResultConfigId { get; set; }
    }
}
