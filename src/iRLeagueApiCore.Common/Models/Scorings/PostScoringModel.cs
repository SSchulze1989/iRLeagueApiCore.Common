using iRLeagueApiCore.Common.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
#if NETCOREAPP  
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
#endif

namespace iRLeagueApiCore.Common.Models
{
    /// <summary>
    /// Schema for creating a new scoring
    /// </summary>
    [DataContract]
    public class PostScoringModel
    {
        /// <summary>
        /// Kind of scoring
        /// </summary>
        [DataMember]
#if NETCOREAPP
        [EnumDataType(typeof(ScoringKind))]
        [JsonConverter(typeof(JsonStringEnumConverter))]
#endif
        public ScoringKind ScoringKind { get; set; }
        /// <summary>
        /// Name of the scoring - shown in results
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Maximum number of results to use for calculating scorin group (e.g: Team scoring)
        /// </summary>
        [DataMember]
        public int MaxResultsPerGroup { get; set; }
        /// <summary>
        /// External source for results if TakeResultsFromExtSource is true
        /// </summary>
        [DataMember]
        public long? ExtScoringSourceId { get; set; }
        /// <summary>
        /// Use teams information available from uploaded result set
        /// </summary>
        [DataMember]
        public bool UseResultSetTeam { get; set; }
        /// <summary>
        /// Update teams information on recalculation - this will overwrite the previous team in a scored row when a recalculation is triggered
        /// If you do not want the team to change after the result has been uploaded first (e.g.: team change during the runnin season) set to false
        /// </summary>
        [DataMember]
        public bool UpdateTeamOnRecalculation { get; set; }
        /// <summary>
        /// Show this result on the result page
        /// If false the results calculated from this scoring wont be 
        /// </summary>
        [DataMember]
        public bool ShowResults { get; set; }
    }
}
