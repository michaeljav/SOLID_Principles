﻿using SOLID._1___O.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1___O.Solution
{
    interface IReportGenerator
    {
        void CreateReport(List<Order> orders);
    }
}
