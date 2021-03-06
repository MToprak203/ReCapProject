﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public string CarName { get; set; }
        public string CompanyName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public Nullable<DateTime> RetunDate { get; set; }

    }
}
