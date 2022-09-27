﻿using iRLeagueApiCore.Common.Models.Members;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Reviews
{
    [DataContract]
    public class VoteModel
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long VoteCategoryId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public MemberInfoModel MemberAtFault { get; set; }
    }
}