using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domovoy.WebApi.Models
{
    public class Building
    {
        public Guid Id { get; set; }
        public virtual Buildings BuildingsId { get; set; }
        public int NumberOfFloors { get; set; }
        public virtual Address Address { get; set; }
    }
}
