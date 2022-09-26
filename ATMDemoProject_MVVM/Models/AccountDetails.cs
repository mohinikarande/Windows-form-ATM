using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ATMDemoProject_MVVM.Models
{
    [Table("AccountDetails")]
    public class AccountDetails
    {
        public int AccountBalance { get; set; }

        public DateTime? TransactionDate { get; set; }

       
        public string CardNumber { get; set; }

        [Key]
        public int Id { get; set; }
        
       
    }
}

   
