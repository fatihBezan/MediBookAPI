using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediBookAPI.DataAccess.Contexts;
using MediBookAPI.Model.Entities;


namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class AppointmentRepository : EfRepositoryBase<Appointment, int, BaseDbContext>, IAppointmentRepository
{
    public AppointmentRepository(BaseDbContext context) : base(context)
    {
    }
}
