﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Areas.Admin.Models
{
    public class BaseAdminModel
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
    }
}