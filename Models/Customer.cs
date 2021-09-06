using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Migrations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [DisplayName("Subscribed to Newsletter?")]
        public bool IsSubscribedToNewsletter { get; set; }

        [DisplayName("Membership Type")]
        public MembershipType MembershipType { get; set; }

        [DisplayName("Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}