using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Grpc.MapperProfiles
{
    public class IMapperInitialize :Profile
    {
        public IMapperInitialize()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
