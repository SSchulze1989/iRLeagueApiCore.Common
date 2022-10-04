using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    /// <summary>
    /// Get a complete scored result from the database
    /// </summary>
    [DataContract]
    public class ResultModel
    {
        /// <summary>
        /// Id of the league
        /// </summary>
        public long LeagueId { get; set; }
        /// <summary>
        /// Id of the season the result belongs to
        /// </summary>
        public long SeasonId { get; set; }
        /// <summary>
        /// Name of the season the result belongs to
        /// </summary>
        [DataMember]
        public string SeasonName { get; set; }
        /// <summary>
        /// Id of the schedule the result belongs to
        /// </summary>
        [DataMember]
        public long ScheduleId { get; set; }
        /// <summary>
        /// Name of the schedule the result belongs to
        /// </summary>
        [DataMember]
        public string ScheduleName { get; set; }
        /// <summary>
        /// Id of the event the result belongs to
        /// </summary>
        [DataMember]
        public long EventId { get; set; }
        /// <summary>
        /// Name of the event the result belongs to
        /// </summary>
        [DataMember]
        public string EventName { get; set; }
        /// <summary>
        /// Id of the session the result belongs to
        /// </summary>
        [DataMember]
        public long? SessionId { get; set; }
        /// <summary>
        /// Name of the session the result belongs to
        /// </summary>
        [DataMember]
        public string SessionName { get; set; }
        /// <summary>
        /// Id of the scoring for this result
        /// </summary>
        [DataMember]
        public long? ScoringId { get; set; }
        /// <summary>
        /// Name of the scoring for this result
        /// </summary>
        [DataMember]
        public string ScoringName { get; set; }
        /// <summary>
        /// List of entries 
        /// </summary>
        [DataMember(IsRequired = true)]
        public IEnumerable<ResultRowModel> ResultRows { get; set; } = Array.Empty<ResultRowModel>();

        #region version
        /// <summary>
        /// Date of creation
        /// </summary>
        [DataMember]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Date of last modification
        /// </summary>
        [DataMember]
        public DateTime? LastModifiedOn { get; set; }
        #endregion
    }
}
