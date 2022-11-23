using iRLeagueApiCore.Common.Models;

namespace iRLeagueApiCore.Common.Tests;

public sealed class IntervalTests
{
    public static IEnumerable<object[]> TestData => new[] {
        new object[] { new TimeSpan(0, 0, 2, 3), new Interval() { Time = new TimeSpan(0, 2, 3), Laps = 0 } },
        new object[] { new TimeSpan(1, 0, 0, 0), new Interval() { Time = new TimeSpan(0, 0, 0), Laps = 1 } },
        new object[] { new TimeSpan(2, 0, 2, 3), new Interval() { Time = new TimeSpan(0, 2, 3), Laps = 2 } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Interval_ShouldConstructFromTimeSpan(TimeSpan time, Interval expected)
    {
        var test = new Interval(time);

        test.Should().Be(expected);
    }
}
