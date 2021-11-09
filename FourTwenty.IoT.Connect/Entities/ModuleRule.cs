﻿using FourTwenty.Core.Data.Models;
using FourTwenty.IoT.Connect.Constants;
using System;

namespace FourTwenty.IoT.Connect.Entities
{
    public class ModuleRule : BaseEntity<int>
    {
        public string RuleName { get; set; }
        public RuleType RuleType { get; set; }
        /// <summary>
        /// Could be complex type (json , separated string's etc)
        /// </summary>
        public string RuleContent { get; set; }
        public int GrowBoxModuleId { get; set; }
        public int? Pin { get; set; }
        public bool IsEnabled { get; set; }
        public virtual GrowBoxModule GrowBoxModule { get; set; }
    }
}
