using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Service.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MediBookAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppointmentsController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentsController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpPost]
    [Authorize]
    public IActionResult Add([FromBody] AppointmentAddRequestDto request)
    {
        _appointmentService.Add(request);
        return Ok("Randevu başarıyla oluşturuldu.");
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAll()
    {
        var appointments = _appointmentService.GetAll();
        return Ok(appointments);
    }

    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetById(int id)
    {
        var appointment = _appointmentService.GetById(id);
        return Ok(appointment);
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult Update(int id, [FromBody] AppointmentUpdateRequestDto request)
    {
        request.Id = id;
        _appointmentService.Update(request);
        return Ok("Randevu başarıyla güncellendi.");
    }

    [HttpDelete("{id}")]
    [Authorize]
    public IActionResult Delete(int id)
    {
        _appointmentService.Delete(id);
        return Ok("Randevu başarıyla silindi.");
    }
} 