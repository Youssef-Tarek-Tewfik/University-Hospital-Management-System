using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Hospital_Management_System.ProjectClasses
{
    public enum UserType
    {
        Patient = 0,
        Doctor = 1,
        Nurse = 2
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum Specialty
    {
        Surgery = 0,
        Radiology = 1,
        Cardiology = 2,
        Dermatology = 3,
        Neurology = 4,
        Pediatrics = 5,
    }

    public class SystemPersona
    {
        public string name;
        public string userName;
        public string password;
        public string ID;
        public string type;
        public string gender;

        public void UpdatePersonalData()
        {

        }
    }
}
