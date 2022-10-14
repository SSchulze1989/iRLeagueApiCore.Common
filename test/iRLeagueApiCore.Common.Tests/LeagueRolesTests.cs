using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace iRLeagueApiCore.Common.Tests
{
    public class LeagueRolesTests
    {
        private static IEnumerable<object> GetTestData(object[] parameters)
        {
            List<object> data = new List<object>();
            data.AddRange(parameters);
            return data;
        }

        [Theory]
        [InlineData("Admin", true, true, true, true)]
        [InlineData("Organizer", false, true, false, true)]
        [InlineData("Steward", false, false, true, true)]
        [InlineData("Member", false, false, false, true)]
        public void ShouldHaveRoles(string roleName, 
            bool admin, 
            bool organizer, 
            bool steward, 
            bool member)
        {
            // Setup
            var role = LeagueRoles.GetRoleValue(roleName);
            var roles = new[] { role };

            LeagueRoles.CheckRole(LeagueRoles.Admin, roles).Should().Be(admin);
            LeagueRoles.CheckRole(LeagueRoles.Organizer, roles).Should().Be(organizer);
            LeagueRoles.CheckRole(LeagueRoles.Steward, roles).Should().Be(steward);
            LeagueRoles.CheckRole(LeagueRoles.Member, roles).Should().Be(member);
        }

        [Theory]
        [InlineData("Admin", new string[0])]
        [InlineData("Organizer", new[] { "Admin" })]
        [InlineData("Steward", new[] { "Admin" })]
        [InlineData("Member", new[] { "Admin", "Organizer", "Steward" })]
        public void ShouldBeImplicitOf(string roleName, string[] implicitOfRoleNames)
        {
            // Setup
            var role = LeagueRoles.GetRoleValue(roleName);
            var implicitOfRoles = implicitOfRoleNames.Select(x => LeagueRoles.GetRoleValue(x)).ToArray();

            // Test
            var testImplicitOfRoles = LeagueRoles.ImplicitRoleOf(role);
            testImplicitOfRoles.Should().HaveSameCount(implicitOfRoles);
            if (implicitOfRoles.Length != 0)
            {
                testImplicitOfRoles.Should().Contain(implicitOfRoles);
            }
        }
    }
}