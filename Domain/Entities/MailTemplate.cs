﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MailTemplate
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public bool Status { get; set; }
    }
}