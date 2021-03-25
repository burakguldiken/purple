using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entity
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int StatusId { get; set; }
    }
}
