﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Role_Auth_Relation
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int AuthID { get; set; }
    }
}