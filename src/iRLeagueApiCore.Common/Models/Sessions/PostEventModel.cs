using iRLeagueApiCore.Common.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class PostEventModel
    {
        public string Name { get; set; }

        [DataMember]
        public EventType EventType { get; set; }
        /// <summary>
        /// Day and time of session start
        /// </summary>
        [DataMember]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Track id of the location
        /// </summary>
        [DataMember]
        public long? TrackId { get; set; }
        /// <summary>
        /// Total duration of the session including all Subsessions and events
        /// </summary>
        [DataMember]
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// Sessions configured for this event
        /// </summary>
        [DataMember]
        public ICollection<SessionModel> Sessions { get; set; }
    }
}