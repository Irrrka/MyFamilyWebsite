namespace MyFamilyAPI.Data
{
    using System;
    using System.Threading.Tasks;

    using MyFamilyAPI.Data.Common;

    using Microsoft.EntityFrameworkCore;

    public class DbQueryRunner : IDbQueryRunner
    {
        public DbQueryRunner(MyFamilyDbContext context)
        {
            this.Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public MyFamilyDbContext Context { get; set; }

        public Task RunQueryAsync(string query, params object[] parameters)
        {
            return this.Context.Database.ExecuteSqlRawAsync(query, parameters);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.Context?.Dispose();
            }
        }
    }
}
