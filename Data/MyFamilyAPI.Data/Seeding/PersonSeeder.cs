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

    internal class PersonSeeder : ISeeder
    {
        public async Task SeedAsync(MyFamilyDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (!dbContext.FamilyTreeNodes.Any())
            {
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Иван",
                    MiddleName = "Маринов",
                    LastName = "Иванов",
                    DayOfBirth = new DateTime(1948, 05, 14),
                    PlaceOfBirth = "Плевен",
                    DayOfDeath = new DateTime(2008, 04, 26),
                    PlaceOfDeath = "София",
                    School = "Техникум",
                    Work = "СТОЛИЧНА ДИРЕКЦИЯ ПОЖАРНА БЕЗОПАСНОСТ И ЗАЩИТА НА НАСЕЛЕНИЕТО",
                    Status = PersonStatus.Death,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Федя",
                    MiddleName = "Генова",
                    MaidenName = "Цанова",
                    LastName = "Маринова",
                    DayOfBirth = new DateTime(1952, 12, 18),
                    PlaceOfBirth = "София",
                    School = "Лесотехнически Университет",
                    Work = "Българска Академия на Науките",
                    Status = PersonStatus.Alive,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Петър",
                    MiddleName = "Иванов",
                    LastName = "Григоров",
                    DayOfBirth = new DateTime(1958, 12, 01),
                    PlaceOfBirth = "с. Белотинци",
                    DayOfDeath = new DateTime(2017, 03, 26),
                    PlaceOfDeath = "Италия",
                    School = "Техникум",
                    Work = "Строител",
                    Status = PersonStatus.Death,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Иванка",
                    MiddleName = "Благоева",
                    MaidenName = "Вачева",
                    LastName = "Григорова",
                    DayOfBirth = new DateTime(1959, 10, 26),
                    PlaceOfBirth = "Монтана",
                    School = "СУ",
                    Work = "Блогър",
                    Status = PersonStatus.Alive,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Ивайло",
                    MiddleName = "Иванов",
                    LastName = "Маринов",
                    DayOfBirth = new DateTime(1980, 02, 22),
                    PlaceOfBirth = "Плевен",
                    School = "УАСГ",
                    Work = "Бизон Дизайн ООД",
                    Status = PersonStatus.Alive,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Ирина",
                    MiddleName = "Петрова",
                    MaidenName = "Григорова",
                    LastName = "Маринова",
                    DayOfBirth = new DateTime(1982, 07, 11),
                    PlaceOfBirth = "София",
                    School = "Софтуерен Университет",
                    Work = "Experian Bulgaria EAD",
                    Status = PersonStatus.Alive,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Явор",
                    MiddleName = "Ивайлов",
                    LastName = "Маринов",
                    DayOfBirth = new DateTime(2013, 09, 07),
                    PlaceOfBirth = "София",
                    School = "141 ДГ",
                    Status = PersonStatus.Alive,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Калин",
                    MiddleName = "Ивайлов",
                    LastName = "Маринов",
                    DayOfBirth = new DateTime(2018, 05, 12),
                    PlaceOfBirth = "София",
                    Status = PersonStatus.Alive,
                });
                await dbContext.FamilyTreeNodes.AddAsync(new FamilyTreeNode
                {
                    FirstName = "Мирослав",
                    MiddleName = "Иванов",
                    LastName = "Маринов",
                    DayOfBirth = new DateTime(1989, 12, 07),
                    PlaceOfBirth = "София",
                    School = "Нов Български Университет",
                    Work = "HR",
                    Status = PersonStatus.Alive,
                });
            }
        }
    }
}
