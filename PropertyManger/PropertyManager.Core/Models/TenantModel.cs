﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManger.Core.Models
{
    public class TenantModel
    {
        public int TenantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
    }
}