using HosbitalTask.Interface;
using HosbitalTask.Models;
using System.Collections.Generic;

namespace HosbitalTask;

internal class Program
{
    static void Main(string[] args)
    {
        AppointmentService appointmentService = new AppointmentService();

        Appointment appointment3 = new Appointment()
        {
            Id = 1,
            PatientName = "Sahub1",
            DoctorName = "Agabala1",
            StartDate = new DateTime(2005, 1, 1),
            EndDate = default(DateTime),

        };
        Appointment appointment4 = new Appointment()
        {
            Id = 2,
            PatientName = "Sahib2",
            DoctorName = "Agabala2",
            StartDate = new DateTime(2005, 7, 7),
            EndDate = new DateTime(2005, 12, 10)

        };

        appointmentService.AddAppointment(appointment3);
        appointmentService.AddAppointment(appointment4);
        bool running = true;
        while (running)
        {
            Console.WriteLine("[1-7] arasi eded daxil edin");
            int index = int.Parse(Console.ReadLine());

            switch (index)
            {
                case 1:

                    Console.WriteLine("   Elave etmek istediyiz elementin ID sini daxil edin");
                    int newID = int.Parse(Console.ReadLine());
                    Console.WriteLine("   Elave etmek istediyiz elementin PatientName-ini daxil edin");
                    string newPatientName = Console.ReadLine();
                    Console.WriteLine("   Elave etmek istediyiz elementin DoctorName-ini daxil edin");
                    string newDoctorName = Console.ReadLine();


                    Appointment appointment1 = new Appointment()
                    {
                        Id = newID,
                        PatientName = newPatientName,
                        DoctorName = newDoctorName,
                        StartDate = DateTime.Now,
                        EndDate = default(DateTime)

                    };


                    appointmentService.AddAppointment(appointment1);


                    List<Appointment> appointments = appointmentService.GetAllAppointments();
                    foreach (var item in appointments)
                    {
                        Console.WriteLine($" Id: {item.Id}\n PatientName: {item.PatientName}\n DoctorName: {item.DoctorName}\n StartDate: {item.StartDate}\n EndDate: {item.EndDate}\n  ");
                    }

                    break;
                case 2:
                    appointmentService.EndAppointment(2);
                    break;

                case 3:
                    List<Appointment> Appointments = appointmentService.GetAllAppointments();
                    foreach (var item in Appointments)
                    {
                        Console.WriteLine($" Id: {item.Id}\n PatientName: {item.PatientName}\n DoctorName: {item.DoctorName}\n StartDate: {item.StartDate}\n EndDate: {item.EndDate}\n  ");
                    }
                    break;
                case 4:

                    appointmentService.GetWeeklyAppointments();

                    break;
                case 5:

                    appointmentService.GetTodaysAppointments();


                    break;
                case 6:

                    appointmentService.GetAllContinuingAppointments();
                    break;
                case 7:
                    running = false;
                    Console.WriteLine("The program has been stopped");
                    break;
                default:
                    Console.WriteLine("[1-7] arasi eded sec");
                    break;
            }
        }
    }
}
