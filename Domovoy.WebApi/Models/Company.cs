using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domovoy.WebApi.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public Buildings Buildings { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
