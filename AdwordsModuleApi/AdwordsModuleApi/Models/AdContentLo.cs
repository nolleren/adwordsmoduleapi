﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdwordsModuleApi.Models
{
    interface IAdContentLo
    {
        string HeadLinePart1 { get; set; }
        string HeadLinePart2 { get; set; }
        string Path1 { get; set; }
        string Path2 { get; set; }
        string Description { get; set; }
    }
    public class AdContentLo : IAdContentLo
    {
        public string HeadLinePart1 { get; set; }
        public string HeadLinePart2 { get; set; }
        public string Path1 { get; set; }
        public string Path2 { get; set; }

        public string Description { get; set; }

    }
}