﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Community.Models
{
    public class UserViewModel
    {
        public string id { get; set; }
        public string email { get; set; }

        public UserViewModel(string id, string email)
        {
            this.id = id;
            this.email = email;
        }
    }
}