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
        public ICollection<int> PointsPerPlace { get; set; } = new List<int>();
        [DataMember]
        public IDictionary<string, int> BonusPoints { get; set; } = new Dictionary<string, int>();
        [DataMember]
        public int MaxPoints { get; set; }
        public int PointDropOff { get; set; }
        public ICollection<SortOptions> PointsSortOptions { get; set; } = new List<SortOptions>();
        public ICollection<SortOptions> FinalSortOptions { get; set; } = new List<SortOptions>();
    }
}
