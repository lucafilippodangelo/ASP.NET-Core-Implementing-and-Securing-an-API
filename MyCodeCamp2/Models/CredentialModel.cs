﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeCamp2.Models
{
  public class CredentialModel
  {
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
  }
}
