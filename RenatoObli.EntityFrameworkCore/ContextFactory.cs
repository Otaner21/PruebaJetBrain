using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RenatoObli.EntityFrameworkCore
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
      
        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();

            builder.UseSqlServer("Server=SQLSERVERLOCAL;DataBase=RenatoObliBD;Trusted_Connection=True;" );// Trusted_Connection=True;");

            return new Context(builder.Options);
        }
    }
}