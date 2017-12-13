using System;

namespace Luffy.RetryMechanism
{
    public class RetryMechanismOptions
    {
        public RetryPolicies RetryPolicies { get; set; }
        public int RetryCount { get; set; }
        public TimeSpan Interval { get; set; } 
    }

    public enum RetryPolicies
    {
        Linear,
        Exponential
    }
}