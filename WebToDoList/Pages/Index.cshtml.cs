using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebToDoList.Models;
using WebToDoList.Services;


namespace WebToDoList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonListService ListService;
        public IEnumerable<ListTask> Lists { get; private set; } 

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonListService listService) 
        {
            _logger = logger;
            ListService = listService;
        }


       

        public void OnGet()
        {
            Lists = ListService.GetLists();
        }

       protected  void ButtonWasClicked (object sender, EventArgs e)
        {

           

           

        }
    }
}
