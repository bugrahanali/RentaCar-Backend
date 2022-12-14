using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos(Expression<Func<Car, bool>> filter = null)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors on c.ColorId equals co.ColorId
                             select new CarDetailDto { 
                                 CarId = c.CarId,
                                 CarName = c.CarName, 
                                 BrandName = b.BrandName, 
                                 DailyPrice = c.DailyPrice, 
                                 ColorName = co.ColorName, 
                                 ModelYear = c.ModelYear, 
                                 Description = c.Description,
                                 ImagePath = (from i in context.Images where i.CarId == c.CarId select i.ImagePath).FirstOrDefault()
                             };
                return result.ToList();
            }
        }

       
    }
}
