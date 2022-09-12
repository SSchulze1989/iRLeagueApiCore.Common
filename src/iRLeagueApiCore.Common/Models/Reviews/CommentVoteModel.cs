using iRLeagueApiCore.Common.Models.Members;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Reviews
{
    [DataContract]
    public class CommentVoteModel
    {
        public long Id { get; set; }
        public MemberInfoModel MemberAtFault { get; set; }
        public VoteCategoryModel VoteCategoryId { get; set; }
    }
}