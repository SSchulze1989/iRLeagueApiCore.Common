using System.Collections.Generic;

namespace iRLeagueApiCore.Common.Models
{
    public class EventResultTabModel : ResultTabModel
    {
        public long EventId { get; set; }
        /// <summary>
        /// Results for the selected Event and Result Tab
        /// </summary>
        public IEnumerable<ResultModel> Results { get; set; }
    }
}
