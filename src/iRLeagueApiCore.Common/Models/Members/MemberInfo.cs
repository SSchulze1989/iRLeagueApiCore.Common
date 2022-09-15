using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Members
{
    [DataContract]
    public class MemberInfoModel
    {
        [DataMember]
        public long MemberId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
    }
}
