using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domovoy.WebApi.Models
{
    public class Buildings
    {
        public Guid Id { get; set; }
        public virtual Company CompanyId {get; set;}
    }
}
