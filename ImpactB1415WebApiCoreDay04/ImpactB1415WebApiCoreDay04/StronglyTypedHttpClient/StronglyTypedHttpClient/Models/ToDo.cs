﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StronglyTypedHttpClient.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
