using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YK.Item.Domain.Entities;

namespace YK.Item.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync();
    }
}
