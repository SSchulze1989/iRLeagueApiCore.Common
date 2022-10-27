using System;
using System.Collections.Generic;

namespace iRLeagueApiCore.Common.Models.Standings
{
    public class StandingsModel
    {
        public long StandingId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsTeamStanding { get; set; }
        public IEnumerable<StandingRowModel> StandingRows { get; set; } = Array.Empty<StandingRowModel>();
    }
}
