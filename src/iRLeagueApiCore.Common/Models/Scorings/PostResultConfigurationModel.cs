using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class PostResultConfigurationModel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
    }
}