﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public int BlogId { get; set; }
        
    }
}
