


using Core.DataAccess.Repositories;
using MediBookAPI.DataAccess.Repositories.Abstracts;
using MediCareAPI.DataAccess.Contexts;
using MediCareAPI.Model.Entities;

namespace MediBookAPI.DataAccess.Repositories.Concretes;

public class AppointmentRepository : EfRepositoryBase<Appointment, int, BaseDbContext>, IAppointmentRepository
{
    public AppointmentRepository(BaseDbContext context) : base(context)
    {
    }
}
