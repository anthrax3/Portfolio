﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }

    }
}