namespace MyFamilyAPI.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(MyFamilyDbContext dbContext, IServiceProvider serviceProvider);
    }
}
