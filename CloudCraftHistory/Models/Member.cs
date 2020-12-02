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
        public string[] Languages { get; set; }

        /* Server References */
        public bool WasStaff { get; set; }

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
        public bool fourteen { get; set; }
        public bool fifteen { get; set; }
        public bool sixteen { get; set; }
        public bool seventeen { get; set; }
        public bool eighteen { get; set; }
        public bool nineteen { get; set; }
        public bool twenty { get; set; }
        public bool twentyone { get; set; }

    }
}
