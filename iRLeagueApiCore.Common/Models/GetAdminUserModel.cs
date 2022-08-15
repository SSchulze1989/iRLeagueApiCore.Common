using System.Collections.Generic;

namespace iRLeagueApiCore.Common.Models
{
    public class GetAdminUserModel
    {
        public string UserName { get; set; }
        public string Firsname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
