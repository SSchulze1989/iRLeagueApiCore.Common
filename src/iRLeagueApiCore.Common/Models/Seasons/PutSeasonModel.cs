using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class PutSeasonModel
    {
        [DataMember]
        public string SeasonName { get; set; }
        [DataMember]
        public long? MainScoringId { get; set; }
        [DataMember]
        public bool HideComments { get; set; }
        [DataMember]
        public bool Finished { get; set; }
    }
}
