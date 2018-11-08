using System.Collections.Generic;

namespace ViewData.Models.Details
{
    public class DataClass
    {
        public int Count { get; set; }

        public ICollection<string> key { get; set; }

        public ICollection<object> Value { get; set; }
    }
}
