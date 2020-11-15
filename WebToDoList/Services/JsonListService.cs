﻿using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using WebToDoList.Models;

namespace WebToDoList.Services
{
    public class JsonListService
    {
        public JsonListService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment =  webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get;}

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "list.json"); }
        }

        public IEnumerable<ListTask> GetLists()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))

            {
                return JsonSerializer.Deserialize<ListTask[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }
}
