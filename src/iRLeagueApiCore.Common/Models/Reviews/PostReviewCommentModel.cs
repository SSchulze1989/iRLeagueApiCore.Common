using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Reviews
{
    [DataContract]
    public class PostReviewCommentModel
    {
        [DataMember]
        public string Text { get; set; } = string.Empty;
        [DataMember]
        public ICollection<VoteModel> Votes { get; set; } = Array.Empty<VoteModel>();
    }
}