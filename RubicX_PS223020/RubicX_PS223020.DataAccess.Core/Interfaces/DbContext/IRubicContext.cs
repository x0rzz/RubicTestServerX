using Microsoft.EntityFrameworkCore;
using RubicX_PS223020.DataAccess.Core.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace RubicX_PS223020.DataAccess.Core.Interfaces.DbContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<UserRoleRto> UserRoles { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
