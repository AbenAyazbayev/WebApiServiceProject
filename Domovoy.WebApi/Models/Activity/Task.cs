using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domovoy.WebApi.Models.Activity
{
    public class Task
    {
        public Guid Id { get; set; }
        public virtual TaskStatus Status { get; set; }
        public virtual Building BuildingId { get; set; }

    }
}
