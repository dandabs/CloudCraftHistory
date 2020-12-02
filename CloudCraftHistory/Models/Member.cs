using System;
using System.ComponentModel.DataAnnotations;

namespace CloudCraftHistory.Models
{
    public class Member
    {

        /* Personal Information */ 
        public int ID { get; set; }
        public string Username { get; set; }
        public string PreferredName { get; set; }
        public string Country { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        /* Interesting Bits */
        public String Languages { get; set; } /*comma-sep*/

        /* Server References */
        public int WasStaff { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        /* Contact Details */
        public string Discord { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Snapchat { get; set; }
        public string Reddit { get; set; }
        public string Twitter { get; set; }
        public string Phone { get; set; }

        /* Years Played */
        public int fourteen { get; set; }
        public int fifteen { get; set; }
        public int sixteen { get; set; }
        public int seventeen { get; set; }
        public int eighteen { get; set; }
        public int nineteen { get; set; }
        public int twenty { get; set; }
        public int twentyone { get; set; }

    }
}
