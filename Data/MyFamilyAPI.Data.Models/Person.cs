namespace MyFamilyAPI.Data.Models
{
    using MyFamilyAPI.Data.Common.Models;
    using MyFamilyAPI.Data.Models.Enums;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    [NotMapped]
    public abstract class Person : BaseModel<Guid>
    {
        //private string lastName;

        //public Person()
        //{
            //this.Schools = new List<string>();
            //this.Works = new List<string>();
        //}

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string MiddleName { get; set; }

        [StringLength(40)]
        public string MaidenName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public PersonStatus Status { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public DateTime? DayOfDeath { get; set; }

        public string PlaceOfDeath { get; set; }

        public string School { get; set; }

        public string Work { get; set; }

        public bool IsSelected { get; set; }

        //public string Details { get; set; }
    }
}
