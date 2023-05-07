using AutoMapper;
using Infrastructure.Entities;
using learnX.Models;

namespace learnX
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<KhachHang, KhachHangViewModel>();
            CreateMap<KhachHangViewModel, KhachHang>();
        }
    }
}
