﻿using System;

namespace Jobsity.Chat.Contracts.Settings
{
    public class MessageBrokerSettings
    {
        public string HostName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public TimeSpan RecoveryInterval { get; set; }
    }
}
