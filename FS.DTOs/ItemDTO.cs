using Entities;
using System;
using System.Linq.Expressions;

namespace FS.DTOs
{
    public class ItemDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public static Expression<Func<Item, ItemDTO>> ProjectTo()
        {
            return x => new ItemDTO
            {
                Id = x.Id,
                Name = x.Name
            };
        }
    }
}
