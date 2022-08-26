using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int ıd);
        IDataResult<List<Car>> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetCarsByBrandId(int ıd);
        IDataResult<List<Car>> GetCarsByColorId(int ıd);
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
    }
}
