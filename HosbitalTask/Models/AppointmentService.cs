using HosbitalTask.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosbitalTask.Models
{

    internal class AppointmentService : IAppointment
    {


        public static List<Appointment> Appointments;

        public AppointmentService()
        {
            Appointments = new List<Appointment>();
        }


        public void AddAppointment(Appointment appointment)
        {
            Appointments.Add(appointment);
        }

        public void EndAppointment(int id)
        {
         
            for (int i = 0; i < Appointments.Count; i++)
            {
                if (id == Appointments[i].Id)
                {
                    Appointments[i].EndDate = DateTime.Now;
                    Console.WriteLine($" Id: {Appointments[i].Id}\n PatientName: {Appointments[i].PatientName}\n DoctorName: {Appointments[i].DoctorName}\n StartDate: {Appointments[i].StartDate}\n EndDate: {Appointments[i].EndDate}\n  ");

                }
            }

            //throw new Exception($"Appointments de bu {id} uygun deyer tapilmadi");

        }



        public List<Appointment> GetAllAppointments()
        {
            return Appointments;
        }

        public void GetAppointmentByID(int id)
        {
            int index = -1;
            for (int i = 0; i < Appointments.Count; i++)
            {
                if (id == Appointments[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {

                Console.WriteLine(Appointments[index]);
            }
            else
            {
                throw new Exception($"Appointments de bu {id} uygun deyer tapilmadi");
            }
        }




        public void GetTodaysAppointments()
        {

            int index = -1;
            for (int i = 0; i < Appointments.Count; i++)
            {

                index = i;
                break;

            }

            if (index != -1)
            {

                if (Appointments[index].StartDate.Day == DateTime.Now.Day)
                {

                    Console.WriteLine($" Id: {Appointments[index].Id}\n PatientName: {Appointments[index].PatientName}\n DoctorName: {Appointments[index].DoctorName}\n StartDate: {Appointments[index].StartDate}\n EndDate: {Appointments[index].EndDate}\n  ");

                }
            }
            else
            {
                throw new Exception($"Appointments de bu  uygun deyer tapilmadi");
            }
        }



        public void GetWeeklyAppointments()
        {
            int index = -1;
            for (int i = 0; i < Appointments.Count; i++)
            {

                index = i;
                break;

            }
            //dateRange.From = DateTime.Today.AddDays(-7);

            if (index != -1)
            {
                if ((Appointments[index].StartDate.Day > 7))
                {

                    if ((Appointments[index].StartDate.Day - 7 > DateTime.Now.Day))
                    {

                        Console.WriteLine($" Id: {Appointments[index].Id}\n PatientName: {Appointments[index].PatientName}\n DoctorName: {Appointments[index].DoctorName}\n StartDate: {Appointments[index].StartDate}\n EndDate: {Appointments[index].EndDate}\n  ");

                    }
                }
            }
            else
            {
                throw new Exception($"Appointments de bu  uygun deyer tapilmadi");
            }
        }





        public void GetAllContinuingAppointments()
        {
            int index = -1;
            for (int i = 0; i < Appointments.Count; i++)
            {

                index = i;
                break;

            }

            if (index != -1)
            {

                if ((Appointments[index].StartDate.Day == DateTime.Now.Day && Appointments[index].EndDate == default(DateTime)))
                {

                    Console.WriteLine($" Id: {Appointments[index].Id}\n PatientName: {Appointments[index].PatientName}\n DoctorName: {Appointments[index].DoctorName}\n StartDate: {Appointments[index].StartDate}\n EndDate: {Appointments[index].EndDate}\n  ");

                }
            }
            else
            {
                throw new Exception($"Appointments de bu  uygun deyer tapilmadi");
            }
        }

       

        public void FilterAppointments(DateTime startDate1, DateTime startDate2)
        {
            int index = -1;
            for (int i = 0; i < Appointments.Count; i++)
            {

                index = i;
                break;

            }

            if (index != -1)
            {

                if ((Appointments[index].StartDate.Day >= startDate1.Day && Appointments[index].StartDate.Day <= startDate2.Day))
                {

                    Console.WriteLine($" Id: {Appointments[index].Id}\n PatientName: {Appointments[index].PatientName}\n DoctorName: {Appointments[index].DoctorName}\n StartDate: {Appointments[index].StartDate}\n EndDate: {Appointments[index].EndDate}\n  ");

                }
            }
            else
            {
                throw new Exception($"Appointments de bu  uygun deyer tapilmadi");
            }
        }
    }
}
