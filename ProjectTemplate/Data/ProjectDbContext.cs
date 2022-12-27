using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectTemplate.Models;

namespace ProjectTemplate.Data
{
    public class ProjectDbContext : IdentityDbContext<AppUser>
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                // lấy về table name trong entity
                string tableName = entityType.GetTableName()!;
                if (tableName.StartsWith("AspNet"))
                {
                    // đổi lại tên table
                    entityType.SetTableName(tableName.Substring(6));    // bỏ 6 ký tự đầu là "AspNet"
                }
            }
        }
    }
}
