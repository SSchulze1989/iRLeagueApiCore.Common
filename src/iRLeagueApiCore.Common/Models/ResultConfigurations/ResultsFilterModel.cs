using iRLeagueApiCore.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRLeagueApiCore.Common.Models.ResultConfigurations
{
    public sealed class ResultsFilterModel
    {
        public long ResultsFilterId { get; set; }
        public long LeagueId { get; set; }
        public string ResultsFilterType { get; set; } = string.Empty;
        public string ColumnPropertyName { get; set; } = string.Empty;
        public ComparatorType Comparator { get; set; }
        public bool Include { get; set; }
        public ICollection<string> FilterValues { get; set; } = Array.Empty<string>();
    }
}
