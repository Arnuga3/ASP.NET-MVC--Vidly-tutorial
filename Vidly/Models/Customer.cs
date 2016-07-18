using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //override the length of the varchar in db in a Name column
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedForNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipId { get; set; }
    }
}