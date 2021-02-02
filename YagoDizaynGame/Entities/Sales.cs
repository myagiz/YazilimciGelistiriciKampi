using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
        public bool StockStatus { get; set; }
        public User User { get; set; }

    }
}
