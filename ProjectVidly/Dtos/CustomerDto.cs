﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ProjectVidly.Models;

namespace ProjectVidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        // [MemberAgeRequirement]
        public DateTime? Birthdate { get; set; }
        
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public byte MembershipTypeId { get; set; }
    }
}