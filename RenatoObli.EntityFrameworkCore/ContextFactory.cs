using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RenatoObli.EntityFrameworkCore
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
      
        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();

            builder.UseSqlServer(@"Server=DESKTOP-MNVS5C9\SQLEXPRESS;DataBase=RenatoObliBD;Trusted_Connection=True;" );// Trusted_Connection=True;");

            return new Context(builder.Options);
        }
    }
}