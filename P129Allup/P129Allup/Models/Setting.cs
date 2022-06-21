﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace P129Allup.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required, StringLength (maximumLength:255)]
        public string Key { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Value { get; set; }

    }
}
