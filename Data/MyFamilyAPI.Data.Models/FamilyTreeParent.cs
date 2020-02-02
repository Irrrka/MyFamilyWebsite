using MyFamilyAPI.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFamilyAPI.Data.Models
{
    public class FamilyTreeParent : BaseModel<Guid>
    {
        public Guid FamilyTreeNodeId { get; set; }

        public virtual FamilyTreeNode FamilyTreeNode { get; set; }

        public Guid? MotherId { get; set; }

        public virtual FamilyTreeNode Mother { get; set; }

        public Guid? FatherId { get; set; }

        public virtual FamilyTreeNode Father { get; set; }
    }
}
