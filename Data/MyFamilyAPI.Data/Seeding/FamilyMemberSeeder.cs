namespace MyFamilyAPI.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using MyFamilyAPI.Common;
    using MyFamilyAPI.Data.Models;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using System.Collections.Generic;
    using MyFamilyAPI.Data.Models.Enums;
    using Microsoft.EntityFrameworkCore;

    internal class FamilyMemberSeeder : ISeeder
    {
        public async Task SeedAsync(MyFamilyDbContext dbContext, IServiceProvider serviceProvider)
        {
            var ivan = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Иван");
            var fedia = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Федя");
            var ivaylo = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Ивайло");
            var miroslav = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Мирослав");
            var irina = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Ирина");
            var peter = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Петър");
            var ivanka = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Иванка");
            var yavor = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Явор");
            var kalin = await dbContext.FamilyTreeNodes.FirstOrDefaultAsync(n => n.FirstName == "Калин");

            ivan.Spouse = fedia;
            fedia.Spouse = ivan;
            peter.Spouse = ivanka;
            ivanka.Spouse = peter;

            FamilyTreeParent ivosParents = new FamilyTreeParent
            {
                Mother = fedia,
                Father = ivan,
            };
            ivaylo.FamilyTreeParent = ivosParents;
            ivaylo.Spouse = irina;

            FamilyTreeParent irinasParents = new FamilyTreeParent
            {
                Mother = ivanka,
                Father = peter,
            };
            irina.FamilyTreeParent = irinasParents;
            irina.Spouse = ivaylo;

            FamilyTreeParent yavorsParents = new FamilyTreeParent
            {
                Mother = irina,
                Father = ivaylo,
            };
            yavor.FamilyTreeParent = yavorsParents;

            FamilyTreeParent kalinsParents = new FamilyTreeParent
            {
                Mother = irina,
                Father = ivaylo,
            };
            kalin.FamilyTreeParent = kalinsParents;
        }
    }
}
