using Infrastructure.EF;
using Infrastructure.Entities;
using Infrastructure.Generic;

namespace Infrastructure.Repository
{
    public interface IKhachHangRepository : IRepository<KhachHang>
    {
    }

    public class KhachHangRepository : Repository<KhachHang>, IKhachHangRepository
    {
        public KhachHangRepository(EXDbContext context) : base(context)
        {
        }
    }
}
