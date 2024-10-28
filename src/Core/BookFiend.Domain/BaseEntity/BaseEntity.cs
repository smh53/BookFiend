﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Domain.BaseEntity
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }

    }

}
