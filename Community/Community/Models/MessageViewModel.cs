﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace Community.Models
{
    public class MessageViewModel
    {
        public int Id { get; set; } // Id for Entity Framework and database

        public string TheMessage { get; set; }

        public string Title { get; set; }

        // Navigation property
        public string Sender { get; set; }

        public MessageViewModel() 
        { 
        //empty constructor 
        }

        public MessageViewModel(Message message)
        {
            this.Id = message.Id;
            this.TheMessage = message.TheMessage;
            this.Title = message.Title;
            var db = new ApplicationDbContext();
            var lol = db.Users.Where(u => u.Id.Equals(message.Sender)).Single();

            this.Sender = lol.Email;

        }


    }
}