using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class EventResultModel
    {
        [DataMember]
        public long LeagueId { get; set; }
        [DataMember]
        public long EventId { get; set; }
        [DataMember]
        public long ResultId { get; set; }
        [DataMember]
        public long SeasonId { get; set; }
        [DataMember]
        public string EventName { get; set; } = string.Empty;
        [DataMember]
        public string DisplayName { get; set; } = string.Empty;
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public long TrackId { get; set; }
        [DataMember]
        public string TrackName { get; set; } = string.Empty;
        [DataMember]
        public string ConfigName { get; set; } = string.Empty;
        [DataMember]
        public IEnumerable<ResultModel> SessionResults { get; set; } = Array.Empty<ResultModel>();
    }
}
