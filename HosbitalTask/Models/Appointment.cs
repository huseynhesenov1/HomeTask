namespace HosbitalTask.Models;



public class Appointment
{
    public int Id { get; set; }
    public string PatientName { get; set; }
    public string DoctorName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }

}