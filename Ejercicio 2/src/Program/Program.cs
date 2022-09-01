using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand","3245","45","Oculista");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "457890658", "5555-555-555", DateTime.Now, "Queen Street", "Maradona","3345","24","Otorrino");
            Console.WriteLine(appointmentResult2);
        }
    }
}
