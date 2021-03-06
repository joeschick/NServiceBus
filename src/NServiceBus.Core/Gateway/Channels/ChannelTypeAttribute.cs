﻿using System;

namespace NServiceBus.Gateway.Channels
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class ChannelTypeAttribute : Attribute
    {
        public ChannelTypeAttribute(string type)
        {
            Type = type;
        }

        public string Type { get; set; }
    }
}
