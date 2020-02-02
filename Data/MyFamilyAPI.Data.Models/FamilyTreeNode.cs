using MyFamilyAPI.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyFamilyAPI.Data.Models
{
    public class FamilyTreeNode : FamilyNode
    {
        //public Guid FamilyNodeId { get; set; }

        //public virtual FamilyNode FamilyNode { get; set; }

        public Guid? SpouseId { get; set; }

        public virtual FamilyTreeNode Spouse { get; set; }

        public Guid? FamilyTreeParentId { get; set; }

        public virtual FamilyTreeParent FamilyTreeParent{ get; set; }
    }
}
