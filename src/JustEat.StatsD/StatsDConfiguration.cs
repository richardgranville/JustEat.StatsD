﻿using System.Globalization;

namespace JustEat.StatsD
{
    public class StatsDConfiguration
    {
        public const int DefaultPort = 8125;

        public string Host { get; set; }

        public int Port { get; set; } = DefaultPort;
        public string Prefix { get; set; } = string.Empty;
        public CultureInfo Culture { get; set; } = CultureInfo.InvariantCulture;
    }
}