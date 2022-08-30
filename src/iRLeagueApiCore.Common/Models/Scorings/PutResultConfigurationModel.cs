using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class PutResultConfigurationModel : PostResultConfigurationModel
    {
        /// <summary>
        /// List of scorings for this result config
        /// --> pair of (SessionIndex, ScoringId)
        /// </summary>
        [DataMember]
        public IEnumerable<(int, long)> ScoringIds { get; set; }
    }
}