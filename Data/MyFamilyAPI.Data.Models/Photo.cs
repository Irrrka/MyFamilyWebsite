using MyFamilyAPI.Data.Common.Models;
using System;
using System.Collections.Generic;

namespace MyFamilyAPI.Data.Models
{
    public class Photo : BaseModel<Guid>
    {
        public DateTime? DateOfPhoto { get; set; }

        public string Url { get; set; }

    }
}