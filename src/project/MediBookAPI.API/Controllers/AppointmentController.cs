using MediBookAPI.Service.Abstracts;
using MediBookAPI.Service.Concretes;
using MediCareAPI.Model.Dtos.Appointments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediBookAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpPost("Add")]
    public IActionResult Add(AppointmentAddRequestDto dto)
    {
        _appointmentService.Add(dto);
        return Ok("Rndevu başarı ile alındı");
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    { 
        var response=_appointmentService.GetAll();
        return Ok(response);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)  
    { 
        var response = _appointmentService.GetById(id); 
        return Ok(response);
    }

    [HttpPut("update")]

    public IActionResult Update(AppointmentUpdateRequestDto dto) 
    { 
        _appointmentService.Update(dto);
        return Ok("Randevu güncellendi");
    }

    [HttpDelete("delete")]
    public IActionResult Delete(int id)  
    { 
        _appointmentService.Delete(id);
        return Ok("randevu silindi");
    }
}
