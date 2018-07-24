using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domovoy.WebApi.Models.Activity
{
    public class IssueType
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Code { get; set; }
    }
}
