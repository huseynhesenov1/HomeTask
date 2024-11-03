using HosbitalTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosbitalTask.Interface
{
    internal interface IAppointment
    {
        void AddAppointment(Appointment appointment);
        void EndAppointment(int id);
        void GetAppointmentByID(int id);
        List<Appointment> GetAllAppointments();
        void GetWeeklyAppointments();
        void GetTodaysAppointments();
        void GetAllContinuingAppointments();
        void FilterAppointments(DateTime startDate1, DateTime startDate2);
    }
}
