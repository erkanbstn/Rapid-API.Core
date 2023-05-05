﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsume.EntityLayer.Concrete
{
    public class Room : BaseEntity
    {
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public bool Wifi { get; set; }
        public string Description { get; set; }
        public string No { get; set; }
        public bool RoomStatus { get; set; }
    }
}
