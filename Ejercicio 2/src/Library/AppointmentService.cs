using System;
using System.Text;

namespace Library
{
    public class AppointmentService // Se deberían crear otras clases para guardar los datos de los objetos interactuando en una consulta y que cada clase se ocupe solo de un aspecto
    { 
    //También se agregan otros datos útiles, como la edad del paciente, el nro de consulta, la especialidad del doctor.
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName, string appointmentCode, string edadPaciente, string doctorSpeciality )
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentCode))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment code' is required\n");
                isValid = false;
            }
            
            if (string.IsNullOrEmpty(edadPaciente))
            {
                stringBuilder.Append("Unable to schedule appointment, 'edad paciente' is required\n");
                isValid = false;
            }
            
            if (string.IsNullOrEmpty(doctorSpeciality))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor Speciality' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
                new Patient (name, id, phoneNumber, edadPaciente);
                new Doctor (doctorName, doctorSpeciality);
                new Appointment (date,appoinmentPlace,appointmentCode);

            }

            return stringBuilder.ToString();
        }

    }
    public class Patient //Clase para guardar los datos del paciente
    {
        public string name { get; set; }
        public string id { get; set; }
        public string phoneNumber { get; set; }
        public string edadPaciente { get; set; }
        
        public Patient (string name, string id, string phoneNumber, string edadPaciente)
        {
            this.name = name;
            this.id = id;
            this.phoneNumber = phoneNumber;
            this.edadPaciente = edadPaciente;        
        }
    }
    public class Doctor //Clase para guardar los datos del doctor
    {
        public string doctorName { get; set;}
        public string doctorSpeciality { get; set; }
        public Doctor(string doctorName, string doctorSpeciality)
        {
            this.doctorName = doctorName;
            this.doctorSpeciality = doctorSpeciality;
        }
    }
    public class Appointment // Clase para guardar los datos del appointment
    {
        public DateTime date;
        public string appointmentPlace;
        public string appointmentCode;
        public Appointment(DateTime date, string appoinmentPlace, string appointmentCode)
        {
            this.date = date;
            this.appointmentPlace = appoinmentPlace;
            this.appointmentCode = appointmentCode;
        }
    }
    
}
