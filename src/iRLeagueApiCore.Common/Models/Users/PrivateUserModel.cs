﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Users
{
    /// <summary>
    /// User model including potentially personal details
    /// </summary>
    [DataContract]
    public class PrivateUserModel : UserModel
    {
        [DataMember]
        public string Email { get; set; } = string.Empty;
    }
}