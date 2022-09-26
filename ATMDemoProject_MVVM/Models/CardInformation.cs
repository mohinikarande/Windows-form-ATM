using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATMDemoProject_MVVM.Models
{
    [Table("CardInformation")]
    public class CardInformation
    {
        [Key]
        public string CardNumber { get; set; }

        public string UserName { get; set; }

        public int? Pin { get; set; }

    }
}
   
