using ApiAuthJwt.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAuthJwt.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("workstation id = fafeviba.mssql.somee.com;packet size = 4096; user id = fafeviba_SQLLogin_1; pwd = vkhe6k3tu4; data source = fafeviba.mssql.somee.com; persist security info = False; initial catalog = fafeviba;Encrypt=False");
            //
            //"Server=.\\SQLExpress; Database=jwt;Trusted_Connection=true; TrustServerCertificate=true;"
        }


        public DbSet<User> Users { get; set; }
    }
}
