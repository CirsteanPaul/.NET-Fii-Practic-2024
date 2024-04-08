using Data.Entities;
namespace Services.Features.Car;

public interface ICarService
{ 
    int CreateCar(CreateCarDto dto);
    Data.Entities.Car GetCarById(int id);
}