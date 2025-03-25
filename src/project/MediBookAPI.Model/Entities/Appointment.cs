

using Core.DataAccess.Entities;

namespace MediCareAPI.Model.Entities
{

    public sealed class Appointment: Entity<int>
    {
        public Appointment()
        {
            Notes=string.Empty;
        }

        public DateTime AppointmentDate { get; set; }

        public string Notes { get; set; }



        public int DoctorId { get; set; }

        public int PatientId { get; set; }


    }
}
