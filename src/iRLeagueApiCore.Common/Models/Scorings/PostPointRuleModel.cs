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
        public IReadOnlyCollection<int> PointsPerPlace { get; set; }
        [DataMember]
        public IReadOnlyDictionary<string, int> BonusPoints { get; set; }
        [DataMember]
        public int MaxPoints { get; set; }
        public int PointDropOff { get; set; }
        public IReadOnlyCollection<SortOptions> PointsSortOptions { get; set; }
        public IReadOnlyCollection<SortOptions> FinalSortOptions { get; set; }
    }
}
