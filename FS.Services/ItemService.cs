using FS.DTOs;
using FS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FS.Services
{
    public class ItemService : IItemService
    {
        private List<ItemDTO> AllItems { get; set; }

        public ItemService()
        {
            AllItems = new List<ItemDTO>()
            {
                new ItemDTO() { Id = 1, Name ="Alfa" },
                new ItemDTO() { Id = 2, Name ="Bravo" },
                new ItemDTO() { Id = 3, Name ="Charlie" }
            };
        }

        public List<ItemDTO> GetAll()
        {
            return this.AllItems;
        }
        public ItemDTO GetById(int id)
        {
            var result = this.AllItems.FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                throw new Exception($"Item with id {id} not found");
            }

            return result;
        }
    }
}
