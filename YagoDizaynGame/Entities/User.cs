﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User:EDevlet
    {
        [Key]
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }

    }
}
