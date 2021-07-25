using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
namespace Api.Data
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        
     
    public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Port=3306;Database=dbTriMania;Uid=root;Pwd=1623740jns";
            var optionBuilder = new DbContextOptionsBuilder<MyContext>();
            optionBuilder.UseMySql(connectionString);
            return new MyContext(optionBuilder.Options);
        }
    }
}
