using iRLeagueApiCore.Common.Models.Members;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Reviews
{
    [DataContract]
    public class PostReviewModel
    {
        [DataMember]
        public string IncidentKind { get; set; }
        [DataMember]
        public string FullDescription { get; set; }
        [DataMember] 
        public string OnLap { get; set; }
        [DataMember]
        public string Corner { get; set; }
        [DataMember] 
        public TimeSpan TimeStamp { get; set; }
        [DataMember] 
        public string IncidentNr { get; set; }
        [DataMember]
        public ICollection<MemberInfoModel> InvolvedMembers { get; set; }
    }
}
