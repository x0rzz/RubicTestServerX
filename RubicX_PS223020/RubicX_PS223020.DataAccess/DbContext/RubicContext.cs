using Microsoft.EntityFrameworkCore;
using RubicX_PS223020.DataAccess.Core.Interfaces.DbContext;
using RubicX_PS223020.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubicX_PS223020.DataAccess.DbContext
{
    public class RubicContext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicContext(DbContextOptions<RubicContext> options) 
            : base(options)
        {
        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }
    }
}
