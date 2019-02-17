using Microsoft.EntityFrameworkCore;
using SlipManagementApi.Database.Tables;
using SlipManagementApi.Models.Request;
using SlipManagementApi.Models.Response;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlipManagementApi.Database
{
    public class SqlContext : DbContext
    {
        private string _connectionString;

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Slip> Slips { get; set; }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("dbo");
            SeedEmployees(modelBuilder);
            SeedSlips(modelBuilder);
        }

        #region Slip CRUD
        public async Task<SlipModel> CreateSlip(CreateSlipModel model)
        {
            var newSlip = new Slip
            {

            };

            var result = Slips.Add(newSlip);
            await SaveChangesAsync();

            return new SlipModel(result.Entity);
        }

        public async Task<SlipModel> GetSlip(long id) => new SlipModel(await Slips.FindAsync(id));

        public async Task<IList<SlipModel>> GetAllSlips() =>
            await Slips.Select(a => new SlipModel(a))
                       .ToListAsync();

        public async Task<SlipModel> UpdateSlip(long id, UpdateSlipModel model)
        {
            var slip = await Slips.FindAsync(id);
            if (slip != null)
            {
                var update = new Slip
                {
                    Id = id
                };

                var result = Slips.Update(update);
                await SaveChangesAsync();

                return new SlipModel(result.Entity);
            }

            return null;
        }

        public async Task<SlipModel> DeleteSlip(long id) =>
            new SlipModel(Slips.Remove(await Slips.FindAsync(id)).Entity);
        #endregion

        #region Employee CRUD
        public async Task<EmployeeModel> CreateEmployee(CreateEmployeeModel model)
        {
            var newSlip = new Employee
            {

            };

            var result = Employees.Add(newSlip);
            await SaveChangesAsync();

            return new EmployeeModel(result.Entity);
        }

        public async Task<EmployeeModel> GetEmployee(long id) => new EmployeeModel(await Employees.FindAsync(id));

        public async Task<IList<EmployeeModel>> GetAllEmployees() =>
            await Employees.Select(employee => new EmployeeModel(employee))
                       .ToListAsync();

        public async Task<EmployeeModel> UpdateEmployee(long id, UpdateEmployeeModel model)
        {
            var slip = await Employees.FindAsync(id);
            if (slip != null)
            {
                var update = new Employee
                {
                    Id = id
                };

                var result = Employees.Update(update);
                return new EmployeeModel(result.Entity);
            }

            return null;
        }

        public async Task<EmployeeModel> DeleteEmployee(long id) =>
            new EmployeeModel(Employees.Remove(await Employees.FindAsync(id)).Entity);
        #endregion

        #region Helper Methods
        private async void Init()
        {
            await Database.EnsureCreatedAsync();
            await Database.MigrateAsync();
        }

        private void SeedEmployees(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new List<Employee>
            {
                new Employee { Id = 1L, FirstName = "Tebogo", LastName = "Seshibe", Age = 24 }
            });
        }

        private void SeedSlips(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slip>().HasData(new List<Slip>
            {
                new Slip { Id = 1L, EmployeeId = 1 }
            });
        }
        #endregion
    }
}
