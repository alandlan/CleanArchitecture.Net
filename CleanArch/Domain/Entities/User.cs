﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
