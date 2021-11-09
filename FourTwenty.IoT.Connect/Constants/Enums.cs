﻿namespace FourTwenty.IoT.Connect.Constants
{
    public enum ComponentType
    {
        Temperature = 1,
        HumidityAndTemperature = 2,
        RangeFinder = 3,
        SoilMoisture = 4,
        Relay = 5,
        Camera = 6
    }

    public enum RuleType : byte
    {
        Cron = 1,
        Action = 2,
        Display = 3,
    }

    public enum JobType
    {
        Read = 1,
        Toggle = 2,
        On = 3,
        Off = 4,
        Period = 5,
        //Action = 6,
    }

    public enum DisplayType
    {
        Text = 1,
        Percent = 2,
    }

    public enum ActionType
    {
        Pre = 1,
        Post = 2
    }

    public enum RelayState
    {
        Opened = 1,
        Closed = 2
    }

    public enum HealthCheck
    {
        Unhealthy,
        Degraded,
        Healthy,
    }

    public enum WorkState
    {
        Running,
        Paused,
        Stopped,
        Mixed
    }
    
    public enum DhtType
    {
        Dht11 = 1,
        Dht22 = 2
    }

    public enum SensorReadType 
    {
        Digital = 1,
        Analog = 2 // Use only with MCP3008 converter
    }
}
