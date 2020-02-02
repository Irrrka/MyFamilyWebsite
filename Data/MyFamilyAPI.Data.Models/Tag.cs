using MyFamilyAPI.Data.Common.Models;
using System;

namespace MyFamilyAPI.Data.Models
{
    public class Tag : BaseModel<Guid>
    {
        public string Name { get; set; }
    }
}