﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Entities.DBSet
{
    public class Achievement: BaseEntity
    {
        public int RaceWins { get; set; }
        public int PolePosition { get; set; }
        public int FastestLap { get; set; }
        public int WorldChampionship { get; set; }
        public Guid DriverId { get; set; }

        public virtual Driver? Driver { get; set; }
    }
}
