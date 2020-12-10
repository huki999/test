﻿namespace PetsDate.Data.Models
{
    using PetsDate.Data.Common.Models;

    public class AnimalImage : BaseModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int AnimalId { get; set; }

        public virtual Animal Animal { get; set; }

        public string ImageUrl { get; set; }
    }
}
