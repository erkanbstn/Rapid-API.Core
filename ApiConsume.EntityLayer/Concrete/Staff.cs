﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiConsume.EntityLayer.Concrete
{
    public class Staff : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string Social1 { get; set; }
        public string Social2 { get; set; }
        public string Social3 { get; set; }
    }
}
