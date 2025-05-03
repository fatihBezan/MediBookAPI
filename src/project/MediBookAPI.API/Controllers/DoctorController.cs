using Microsoft.AspNetCore.Http;
using MediBookAPI.Service.Abstracts;
using MediBookAPI.Model.Dtos.Doctors;
using Microsoft.AspNetCore.Mvc;

namespace MediBookAPI.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DoctorController : ControllerBase
{
    private readonly IDoctorService _doctorService;

    public DoctorController(IDoctorService doctorService)
    {
        _doctorService = doctorService;
    }

    [HttpPost("add")]
    public IActionResult Add(DoctorAddRequestDto dto)
    {
        _doctorService.Add(dto);
        return Ok();
    }
    [HttpGet("get all")]

    public IActionResult GetAl() 
    {
        var result=_doctorService.GetAll();
        return Ok(result);

    }
}
