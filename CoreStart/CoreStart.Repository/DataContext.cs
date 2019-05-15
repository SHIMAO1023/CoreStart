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
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<FunctionModule> FunctionModules { get; set; }

        public DbSet<FunctionModuleRole> FunctionModuleRoles { get; set; }
    }
}
