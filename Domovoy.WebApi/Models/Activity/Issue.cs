using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domovoy.WebApi.Models.Activity
{
    public class Issue
    {
        public Guid Id { get; set; }
        public virtual IssueType Type { get; set; }
        public virtual Task TaskId { get; set; }
    }
}
