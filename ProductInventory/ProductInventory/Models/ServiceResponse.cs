﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductInventory.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }

        public bool Sucess { get; set; } = true;

        public string Message { get; set; } = null;
    }
}
