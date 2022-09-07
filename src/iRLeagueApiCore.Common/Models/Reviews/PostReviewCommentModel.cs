﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Reviews
{
    [DataContract]
    public class PostReviewCommentModel
    {
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public ICollection<CommentVoteModel> Votes { get; set; }
    }
}