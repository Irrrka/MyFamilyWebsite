using MyFamilyAPI.Data.Common.Models;
using System;

namespace MyFamilyAPI.Data.Models
{
    public class FamilyMemberPhoto : BaseModel<Guid>
    {
        public Guid PhotoId { get; set; }

        public virtual Photo Photo { get; set; }

        public Guid FamilyMemberId { get; set; }

        public virtual FamilyNode FamilyMember { get; set; }
    }
}