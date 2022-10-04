using System;
using System.Collections.Generic;

namespace iRLeagueApiCore.Common.Models.Users
{
    public class GetAdminUserModel
    {
        public string UserName { get; set; } = string.Empty;
        public string Firsname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public IEnumerable<string> Roles { get; set; } = Array.Empty<string>();
    }
}
