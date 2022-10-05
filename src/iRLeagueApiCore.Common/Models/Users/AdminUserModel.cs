using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace iRLeagueApiCore.Common.Models.Users
{
    /// <summary>
    /// User model that is only retrieved by admin functionality
    /// Shows all roles the user is in
    /// </summary>
    [DataContract]
    public class AdminUserModel : LeagueUserModel
    {
        [DataMember]
        public IEnumerable<string> Roles { get; set; } = Array.Empty<string>();
    }
}
