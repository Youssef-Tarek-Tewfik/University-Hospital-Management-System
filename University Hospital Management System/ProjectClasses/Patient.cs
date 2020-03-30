using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Hospital_Management_System.ProjectClasses
{
    public class Patient : SystemPersona
    {
        private string age;
        private string contactNumber;
        private Doctor primaryCaretaker;

        public Patient(string name, string userName, string password, string iD, string gender, string age, string contactNumber)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.userName = userName ?? throw new ArgumentNullException(nameof(userName));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
            ID = iD ?? throw new ArgumentNullException(nameof(iD));
            this.gender = gender ?? throw new ArgumentNullException(nameof(gender));
            this.age = age ?? throw new ArgumentNullException(nameof(age));
            this.contactNumber = contactNumber ?? throw new ArgumentNullException(nameof(contactNumber));
        }


    }
}
