using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class EventModel : PutEventModel
    {
        /// <summary>
        /// EventId
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long LeagueId { get; set; }
        /// <summary>
        /// Id of the schedule this event belongs to
        /// </summary>
        [DataMember]
        public long ScheduleId { get; set; }
        [DataMember]
        public bool HasResult { get; set; }
    }
}
