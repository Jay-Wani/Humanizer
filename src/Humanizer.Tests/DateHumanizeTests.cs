﻿using Humanizer.Localisation;
using Xunit.Extensions;

namespace Humanizer.Tests
{
    public class DateHumanizeTests
    {
        [Theory]
        [InlineData(1, "one second ago")]
        [InlineData(10, "10 seconds ago")]
        [InlineData(59, "59 seconds ago")]
        [InlineData(60, "a minute ago")]
        public void SecondsAgo(int seconds, string expected)
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, TimeUnitTense.Past);
        }

        [Theory]
        [InlineData(1, "one second from now")]
        [InlineData(10, "10 seconds from now")]
        [InlineData(59, "59 seconds from now")]
        [InlineData(60, "a minute from now")]
        public void SecondsFromNow(int seconds, string expected)
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, TimeUnitTense.Future);
        }

        [Theory]
        [InlineData(1, "a minute ago")]
        [InlineData(10, "10 minutes ago")]
        [InlineData(44, "44 minutes ago")]
        [InlineData(45, "an hour ago")]
        [InlineData(119, "an hour ago")]
        [InlineData(120, "2 hours ago")]
        public void MinutesAgo(int minutes, string expected)
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, TimeUnitTense.Past);
        }

        [Theory]
        [InlineData(1, "a minute from now")]
        [InlineData(10, "10 minutes from now")]
        [InlineData(44, "44 minutes from now")]
        [InlineData(45, "an hour from now")]
        [InlineData(119, "an hour from now")]
        [InlineData(120, "2 hours from now")]
        public void MinutesFromNow(int minutes, string expected)
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, TimeUnitTense.Future);
        }

        [Theory]
        [InlineData(1, "an hour ago")]
        [InlineData(10, "10 hours ago")]
        [InlineData(23, "23 hours ago")]
        [InlineData(24, "yesterday")]
        public void HoursAgo(int hours, string expected)
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, TimeUnitTense.Past);
        }

        [Theory]
        [InlineData(1, "an hour from now")]
        [InlineData(10, "10 hours from now")]
        [InlineData(23, "23 hours from now")]
        [InlineData(24, "tomorrow")]
        public void HoursFfomNow(int hours, string expected)
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, TimeUnitTense.Future);
        }

        [Theory]
        [InlineData(1, "yesterday")]
        [InlineData(10, "10 days ago")]
        [InlineData(28, "28 days ago")]
        [InlineData(32, "one month ago")]
        public void DaysAgo(int days, string expected)
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, TimeUnitTense.Past);
        }

        [Theory]
        [InlineData(1, "tomorrow")]
        [InlineData(10, "10 days from now")]
        [InlineData(28, "28 days from now")]
        [InlineData(32, "one month from now")]
        public void DaysFromNow(int days, string expected)
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, TimeUnitTense.Future);
        }

        [Theory]
        [InlineData(1, "one month ago")]
        [InlineData(10, "10 months ago")]
        [InlineData(11, "11 months ago")]
        [InlineData(12, "one year ago")]
        public void MonthsAgo(int months, string expected)
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, TimeUnitTense.Past);
        }

        [Theory]
        [InlineData(1, "one month from now")]
        [InlineData(10, "10 months from now")]
        [InlineData(11, "11 months from now")]
        [InlineData(12, "one year from now")]
        public void MonthsFromNow(int months, string expected)
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, TimeUnitTense.Future);
        }

        [Theory]
        [InlineData(1, "one year ago")]
        [InlineData(2, "2 years ago")]
        public void YearsAgo(int years, string expected)
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, TimeUnitTense.Past);
        }

        [Theory]
        [InlineData(1, "one year from now")]
        [InlineData(2, "2 years from now")]
        public void YearsFromNow(int years, string expected)
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, TimeUnitTense.Future);
        }
    }
}
