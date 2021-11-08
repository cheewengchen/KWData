using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KWData.Models
{
    public class CustomerVM
    {
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public string Tel { get; set; }
        public string IC { get; set; }
        public string Street { get; set; }
        public string PremName { get; set; }
    }
}
