using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RenatoObli.EntityFrameworkCore
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
      
        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();

            builder.UseSqlServer(@"Server=DESKTOP-MNVS5C9\SQLEXPRESS;Database=RenatoObliBD;Trusted_Connection=True;");
          //  Data Source=DESKTOP-MNVS5C9\SQLEXPRESS;Initial Catalog=RenatoObliBD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            return new Context(builder.Options);
        }
    }
}