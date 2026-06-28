using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_web_api.DTOs
{
    public class CategoryCreateDto
    {
        public string Name {get; set;} = string.Empty;
        public string Description {get; set;}= string.Empty;
    }
}