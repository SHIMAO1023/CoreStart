using CoreStart.Domain.Model;
using CoreStart.Domain.Model.Module;
using CoreStart.Domain.Model.Role;
using CoreStart.Domain.Model.RolePermission;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Repository
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //为单个实体配置的全局筛选器
            modelBuilder.Entity<User>().HasQueryFilter(p => p.IsActive);

        }

        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<FunctionModule> FunctionModule { get; set; }

        public DbSet<FunctionModuleRole> FunctionModuleRole { get; set; }
    }
}
