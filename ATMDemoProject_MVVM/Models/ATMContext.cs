using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ATMDemoProject_MVVM.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class ATMContext : DbContext
    {

        public ATMContext() : base("name=connstr")
        {

        }

        public DbSet<CardInformation> CardInformation { get; set; }

        public DbSet<AccountDetails> AccountDetails { get; set; }

    }
}
