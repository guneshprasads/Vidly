using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_2nd_try.Models;

namespace Vidly_2nd_try.Dtos
{
    public class CustomerDtos
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        
        public byte MembershipTypeId { get; set; }
        [Min18YearsIfAMember]
        public DateTime? Dateofbirth { get; set; }
    }
}