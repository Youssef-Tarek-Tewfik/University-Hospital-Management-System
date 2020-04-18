using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Hospital_Management_System.ProjectClasses
{
    public class Patient : SystemPersona
    {
        private int age;
        private string contactNumber;

        public Patient(string name, string userName, string password, string iD, string gender, int age, string contactNumber)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.userName = userName ?? throw new ArgumentNullException(nameof(userName));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
            ID = iD ?? throw new ArgumentNullException(nameof(iD));
            this.gender = gender ?? throw new ArgumentNullException(nameof(gender));
            this.age = age;
            this.contactNumber = contactNumber ?? throw new ArgumentNullException(nameof(contactNumber));
        }


    }
}
