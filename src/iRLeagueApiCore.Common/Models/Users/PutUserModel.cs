﻿
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Users
{
    [DataContract]
    public class PutUserModel
    {
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
