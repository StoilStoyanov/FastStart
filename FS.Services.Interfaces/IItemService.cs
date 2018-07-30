using FS.DTOs;
using System.Collections.Generic;

namespace FS.Services.Interfaces
{
    public interface IItemService
    {
        List<ItemDTO> GetAll();

        ItemDTO GetById(int id);
    }
}
