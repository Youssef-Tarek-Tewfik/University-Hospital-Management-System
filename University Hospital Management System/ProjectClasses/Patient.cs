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

        public Patient(string name, string userName, string password, string iD, UserType type, Gender gender, string age, string contactNumber, Doctor primaryCaretaker)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.userName = userName ?? throw new ArgumentNullException(nameof(userName));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
            ID = iD ?? throw new ArgumentNullException(nameof(iD));
            this.type = type;
            this.gender = gender;
            this.age = age ?? throw new ArgumentNullException(nameof(age));
            this.contactNumber = contactNumber ?? throw new ArgumentNullException(nameof(contactNumber));
            this.primaryCaretaker = primaryCaretaker ?? throw new ArgumentNullException(nameof(primaryCaretaker));
        }


    }
}
