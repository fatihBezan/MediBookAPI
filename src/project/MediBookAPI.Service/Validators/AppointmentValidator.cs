using FluentValidation;
using MediBookAPI.Model.Dtos.Appointments;

namespace MediBookAPI.Service.Validators;

public class AppointmentAddDtoValidator : AbstractValidator<AppointmentAddRequestDto>
{
    public AppointmentAddDtoValidator()
    {
        RuleFor(x => x.DoctorId)
            .NotEmpty()
            .WithMessage("Doktor seçimi zorunludur.");

        RuleFor(x => x.PatientId)
            .NotEmpty()
            .WithMessage("Hasta seçimi zorunludur.");

        RuleFor(x => x.AppointmentDate)
            .NotEmpty()
            .WithMessage("Randevu tarihi zorunludur.")
            .Must(x => x.Year == 2025)
            .WithMessage("Randevu tarihi 2025 yılı için olmalıdır.");

        RuleFor(x => x.Notes)
            .NotEmpty()
            .WithMessage("Randevu notu zorunludur.")
            .MaximumLength(500)
            .WithMessage("Randevu notu en fazla 500 karakter olabilir.");
    }
} 