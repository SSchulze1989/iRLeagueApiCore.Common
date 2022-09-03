using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class PostResultConfigModel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string DisplayName { get; set; }
        [DataMember]
        public IEnumerable<ScoringModel> Scorings { get; set; }
    }
}
