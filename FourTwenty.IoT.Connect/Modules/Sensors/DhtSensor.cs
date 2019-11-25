﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FourTwenty.IoT.Connect.Constants;
using FourTwenty.IoT.Connect.Interfaces.Sensors;
using FourTwenty.IoT.Connect.Models;
using FourTwenty.IoT.Connect.Models.Data;

namespace FourTwenty.IoT.Connect.Modules.Sensors
{
    public class DhtSensor : BaseModule, ISensor<ModuleResponse<DthData>>
    {
        public DhtSensor(string name, int gpioPin, List<ModuleRule> rules = null) : base(gpioPin, rules, name)
        {
            Type = ModuleType.HumidityAndTemperature;
        }

        public Task<ModuleResponse<DthData>> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
