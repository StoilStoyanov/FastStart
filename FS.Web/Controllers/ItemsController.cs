using FS.DTOs;
using FS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FS.Web.Controllers
{
    public class ItemsController : ApiController
    {
        private readonly IItemService itemService;

        public ItemsController(IItemService itemService)
        {
            this.itemService = itemService ?? throw new ArgumentNullException(nameof(itemService));
        }

        [HttpGet]
        public IHttpActionResult GetItem(int id)
        {
            var item = this.itemService.GetById(id);
            return Ok(item);
        }

        [HttpGet]
        [ActionName("all")]
        public IHttpActionResult GetAll()
        {
            var items = this.itemService.GetAll();
            return Ok(items);
        }
    }
}
