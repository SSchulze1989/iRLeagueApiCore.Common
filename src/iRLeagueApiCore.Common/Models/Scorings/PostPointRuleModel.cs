using iRLeagueApiCore.Common.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models
{
    [DataContract]
    public class PostPointRuleModel
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IEnumerable<int> PointsPerPlace { get; set; }
        [DataMember]
        public IDictionary<string, int> BonusPoints { get; set; }
        [DataMember]
        public int MaxPoints { get; set; }
        public int PointDropOff { get; set; }
        public IEnumerable<SortOptions> PointsSortOptions { get; set; }
        public IEnumerable<SortOptions> FinalSortOptions { get; set; }
    }
}
