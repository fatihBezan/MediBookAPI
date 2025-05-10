using MediBookAPI.Model.Dtos.Hospitals;
using MediBookAPI.Service.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MediBookAPI.Model.Entities;

namespace MediBookAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HospitalController : ControllerBase
{
    private readonly IHospitalService _hospitalService;
    private readonly IMapper _mapper;

    public HospitalController(IHospitalService hospitalService, IMapper mapper)
    {
        _hospitalService = hospitalService;
        _mapper = mapper;
    }

    [HttpPost]
    [Authorize]
    public IActionResult Add([FromBody] HospitalAddRequestDto request)
    {
        var hospital = _mapper.Map<Hospital>(request);
        _hospitalService.Add(hospital);
        return Ok("Hastane başarıyla eklendi.");
    }

    [HttpGet]
    [Authorize]
    public IActionResult GetAll()
    {
        var hospitals = _hospitalService.GetAll();
        return Ok(hospitals);
    }

    [HttpGet("{id}")]
    [Authorize]
    public IActionResult GetById(int id)
    {
        var hospital = _hospitalService.GetById(id);
        return Ok(hospital);
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult Update(int id, [FromBody] HospitalUpdateRequestDto request)
    {
        request.Id = id;
        var hospital = _mapper.Map<Hospital>(request);
        _hospitalService.Update(hospital);
        return Ok("Hastane başarıyla güncellendi.");
    }

    [HttpDelete("{id}")]
    [Authorize]
    public IActionResult Delete(int id)
    {
        _hospitalService.Delete(id);
        return Ok("Hastane başarıyla silindi.");
    }
} 