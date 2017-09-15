namespace ContactBook_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string MobileNo { get; set; }

        [StringLength(15)]
        public string TelephoneNo { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? CountryId { get; set; }

        public int? StateId { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }

        public virtual Country Country { get; set; }

        public virtual State State { get; set; }
    }
}
