﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;


namespace WishList.Models
{
    public class Item
    {
        public int Id {get; set;}

        [Required]
        public string Description { get; set; }

	    public Item()
	    {
	    }
    }
}