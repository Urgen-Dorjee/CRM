﻿using System.Collections.Generic;

namespace CRM.Domain.Models.Employees
{
    public class Region
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
        public ICollection<Territory> Territories { get; private set; }
    }
}
