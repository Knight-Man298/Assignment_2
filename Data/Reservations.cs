using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Data
{
    public class Reservations 
    {
        private string reservationcode;
        private string name;
        private string citizenship;
        private bool status; 


        public string Reservationcode { get => reservationcode; set => reservationcode = value; }
        public string Name { get => name; set => name = value; }
        public string Citizenship { get => citizenship; set => citizenship = value; }
        public bool Status { get => status; set => status = value; }

        public Reservations(string reservationcode, string name, string citizenship, bool status)
        {
            this.reservationcode = reservationcode;
            this.name = name;
            this.citizenship = citizenship;
            this.status = status;

        }
    }
}
