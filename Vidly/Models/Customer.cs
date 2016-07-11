using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedForNewsletter { get; set; }
        public MemebershipType MembershipType { get; set; }
        public byte MemebershipId { get; set; }
    }
}