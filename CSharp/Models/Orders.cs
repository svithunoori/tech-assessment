using System;
using System.Collections.Generic;

namespace CSharp.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
