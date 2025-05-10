using AutoMapper;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.Model.Dtos.Appointments;
using MediBookAPI.Model.Entities;
using MediBookAPI.Service.BusinessRules;
using MediBookAPI.Service.Concretes;
using MediBookAPI.Service.Helpers;
using Moq;
using NUnit.Framework;

namespace MediBookAPI.Tests.Services;

[TestFixture]
public class AppointmentServiceTests
{
    private Mock<IAppointmentRepository> _mockAppointmentRepository = null!;
    private Mock<IMapper> _mockMapper = null!;
    private Mock<ICloudinaryHelper> _mockCloudinaryHelper = null!;
    private Mock<AppointmentBusinessRules> _mockBusinessRules = null!;
    private AppointmentService _appointmentService = null!;

    [SetUp]
    public void Setup()
    {
        _mockAppointmentRepository = new Mock<IAppointmentRepository>();
        _mockMapper = new Mock<IMapper>();
        _mockCloudinaryHelper = new Mock<ICloudinaryHelper>();
        _mockBusinessRules = new Mock<AppointmentBusinessRules>();

        _appointmentService = new AppointmentService(
            _mockAppointmentRepository.Object,
            _mockMapper.Object,
            _mockCloudinaryHelper.Object,
            _mockBusinessRules.Object);
    }

    [Test]
    public void Add_ValidAppointment_ShouldAddAppointment()
    {
        // Arrange
        var request = new AppointmentAddRequestDto
        {
            DoctorId = 1,
            PatientId = 1,
            AppointmentDate = new DateTime(2025, 1, 1),
            Notes = "Test randevusu"
        };

        var appointment = new Appointment
        {
            Id = 1,
            DoctorId = request.DoctorId,
            PatientId = request.PatientId,
            AppointmentDate = request.AppointmentDate,
            Notes = request.Notes
        };

        _mockMapper.Setup(m => m.Map<Appointment>(request)).Returns(appointment);

        // Act
        _appointmentService.Add(request);

        // Assert
        _mockBusinessRules.Verify(x => x.CheckIfPatientCanMakeAppointment(request.PatientId, request.AppointmentDate), Times.Once);
        _mockBusinessRules.Verify(x => x.CheckIfAppointmentDateIsValid(request.AppointmentDate), Times.Once);
        _mockAppointmentRepository.Verify(x => x.Add(appointment), Times.Once);
    }

    [Test]
    public void GetById_ExistingId_ShouldReturnAppointment()
    {
        // Arrange
        var appointmentId = 1;
        var appointment = new Appointment
        {
            Id = appointmentId,
            DoctorId = 1,
            PatientId = 1,
            AppointmentDate = new DateTime(2025, 1, 1),
            Notes = "Test randevusu"
        };

        var appointmentResponse = new AppointmentResponseDto
        {
            Id = appointmentId,
            DoctorId = 1,
            PatientId = 1,
            AppointmentDate = new DateTime(2025, 1, 1),
            Notes = "Test randevusu"
        };

        _mockAppointmentRepository.Setup(x => x.GetById(appointmentId)).Returns(appointment);
        _mockMapper.Setup(m => m.Map<AppointmentResponseDto>(appointment)).Returns(appointmentResponse);

        // Act
        var result = _appointmentService.GetById(appointmentId);

        // Assert
        Assert.That(result, Is.Not.Null);
        Assert.That(result.Id, Is.EqualTo(appointmentId));
    }

    [Test]
    public void GetById_NonExistingId_ShouldThrowException()
    {
        // Arrange
        var appointmentId = 999;
        _mockAppointmentRepository.Setup(x => x.GetById(appointmentId)).Returns((Appointment)null!);

        // Act & Assert
        Assert.Throws<Exception>(() => _appointmentService.GetById(appointmentId));
    }

    [Test]
    public void Delete_ExistingId_ShouldDeleteAppointment()
    {
        // Arrange
        var appointmentId = 1;
        var appointment = new Appointment { Id = appointmentId };
        _mockAppointmentRepository.Setup(x => x.GetById(appointmentId)).Returns(appointment);

        // Act
        _appointmentService.Delete(appointmentId);

        // Assert
        _mockAppointmentRepository.Verify(x => x.Delete(appointment), Times.Once);
    }
} 