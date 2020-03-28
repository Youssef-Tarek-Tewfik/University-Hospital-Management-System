using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Hospital_Management_System.ProjectClasses
{
    public class Nurse : SystemPersona
    {
        private Specialty specialty;
        private bool isPractitioner;

        public Nurse(string name, string userName, string password, string iD, UserType type, Gender gender, Specialty specialty, bool isPractitioner)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.userName = userName ?? throw new ArgumentNullException(nameof(userName));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
            ID = iD ?? throw new ArgumentNullException(nameof(iD));
            this.type = type;
            this.gender = gender;
            this.specialty = specialty;
            this.isPractitioner = isPractitioner;
        }


    }
}
