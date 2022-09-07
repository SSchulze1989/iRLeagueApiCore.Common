using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class ResultConfigModel : PutResultConfigModel
    {
        [DataMember]
        public long LeagueId { get; set; }
        [DataMember]
        public long ResultConfigId { get; set; }
    }
}
