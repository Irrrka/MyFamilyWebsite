namespace MyFamilyAPI.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Text;

    [NotMapped]
    public class FamilyNode : Person
    {
        public FamilyNode()
        {
            //this.Children = new LinkedList<FamilyNode>();
            this.Photos = new List<FamilyMemberPhoto>();
            this.PhotoTags = new List<PhotoTag>();
        }

        //public Guid? MotherId { get; set; }

        //public virtual FamilyTreeParent Mother { get; set; }

        //public Guid? FatherId { get; set; }

        //public virtual FamilyTreeParent Father { get; set; }

       // public Guid? FamilyTreeNodeId { get; set; }

       // public virtual FamilyTreeNode FamilyTreeNode { get; set; }

        //public virtual ICollection<FamilyNode> Children { get; set; }

        public virtual ICollection<FamilyMemberPhoto> Photos { get; set; }

        public virtual ICollection<PhotoTag> PhotoTags { get; set; }
    }
}
