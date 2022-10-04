using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRLeagueApiCore.Common.Models
{
    public class EventResultModel
    {
        public long LeagueId { get; set; }
        public long EventId { get; set; }
        public long ResultId { get; set; }
        public long SeasonId { get; set; }
        public string EventName { get; set; }
        public string DisplayName { get; set; }
        public DateTime Date { get; set; }
        public long TrackId { get; set; }
        public string TrackName { get; set; }
        public IEnumerable<ResultModel> SessionResults { get; set; } = Array.Empty<ResultModel>();
    }
}
