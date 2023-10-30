namespace iRLeagueApiCore.Common.Enums;

/// <summary>
/// Setting for type of interval calculation
/// </summary>
public enum IntervalCalculationType
{
    /// <summary>
    /// Interval as reported in race results
    /// </summary>
    Reported,
    /// <summary>
    /// Avg. laptime * number of completed laps
    /// </summary>
    AvgLapTime,
}