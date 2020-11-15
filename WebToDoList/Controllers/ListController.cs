using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebToDoList.Models;
using WebToDoList.Services;

namespace WebToDoList.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        public ListController(JsonListService listService)
        {
            this.ListService = listService;
        }
         
        public JsonListService ListService { get; set; }

         [HttpGet]
        public IEnumerable<ListTask> Get()
        {
            return ListService.GetLists();

        }
    }
}
