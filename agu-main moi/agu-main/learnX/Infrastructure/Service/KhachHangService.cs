using Infrastructure.Entities;
using Infrastructure.Repository;
using System.Linq;

namespace Infrastructure.Service
{
    public interface IKhachHangService
    {
        IQueryable<KhachHang> GetKhachHangs();
        KhachHang GetKhachHang(int id);
        void InsertKhachHang(KhachHang khachHang);
        void UpdateKhachHang(KhachHang khachHang);
        void DeleteKhachHang(KhachHang khachHang);
    }

    public class KhachHangService : IKhachHangService
    {
        private IKhachHangRepository khachHangRepository;

        public KhachHangService(IKhachHangRepository khachHangRepository)
        {
            this.khachHangRepository = khachHangRepository;
        }

        public IQueryable<KhachHang> GetKhachHangs()
        {
            return khachHangRepository.GetAll();
        }

        public KhachHang GetKhachHang(int id)
        {
            return khachHangRepository.GetById(id);
        }

        public void InsertKhachHang(KhachHang khachHang)
        {
            khachHangRepository.Insert(khachHang);
        }

        public void UpdateKhachHang(KhachHang khachHang)
        {
            khachHangRepository.Update(khachHang);
        }

        public void DeleteKhachHang(KhachHang khachHang)
        {
            khachHangRepository.Delete(khachHang);
        }
    }
}
