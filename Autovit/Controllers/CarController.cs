using Autovit.Models.Car;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Features.Cars;

namespace Autovit.Controllers;

[Route("api/car")]
public class CarController : ControllerBase
{
    private readonly ICarService _carService;

    public CarController(ICarService carService)
    {
        _carService = carService;
    }

    [HttpPost]
    public ActionResult<string> CreateCar(CreateCarRequest request, int userId)
    {
        var dto = new CreateCarDto()
        {
            Km = request.Km,
            Model = request.Model,
            Description = request.Description,
            Images = request.Images,
            Year = request.Year,
        };
        
        var id = _carService.CreateCar(dto, userId);

        return Ok($"api/car/{id}");
    }
    
    [HttpGet]
    public ActionResult<Car> CreateCar(int id)
    {
        var car = _carService.GetCarById(id);

        return Ok(car);
    }
}