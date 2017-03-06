﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PocketPenny.Models.Data;

namespace PocketPenny.Models.ViewModels.Pages
{
    public class SidebarVM
    {
        public SidebarVM()
        {
                
        }

        public SidebarVM(SidebarDTO row)
        {
            Id = row.Id;
            Body = row.Body;
        }

        public int Id { get; set; }
        public string Body { get; set; }
    }
}