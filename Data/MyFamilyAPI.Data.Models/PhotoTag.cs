namespace MyFamilyAPI.Data.Models
{
    using MyFamilyAPI.Data.Common.Models;
    using System;

    public class PhotoTag : BaseModel<Guid>
    {
        public Guid PhotoId { get; set; }

        public virtual Photo Photo { get; set; }

        public Guid TagId { get; set; }

        public virtual Tag Tag{ get; set; }
    }
}