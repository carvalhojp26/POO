﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    internal interface IBookingModel
    {
        bool IsValidDate();
        int GetTotalNights();
    }
}
