using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class Message : BaseClass
    {
        public int Id { get; set; }
        public string MessageContent { get; set; }
        public int? From { get; set; }
        public int? To { get; set; }
        public DateTime? ReadAt { get; set; }
    }
}
