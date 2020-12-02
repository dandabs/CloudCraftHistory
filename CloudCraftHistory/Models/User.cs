using System;
using System.ComponentModel.DataAnnotations;

namespace CloudCraftHistory.Models
{
    public class User
    {

        /* Personal Information */ 
        public int ID { get; set; }
        public string Username { get; set; }
        public string PreferredName { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }

        /* Interesting Bits */
        public string[] Languages { get; set; }

        /* Server References */
        public int[] YearsPlaying { get; set; }
        public int[] YearsStaffing { get; set; }

        /* Contact Details */
        public string Discord { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Snapchat { get; set; }
        public string Reddit { get; set; }
        public string Twitter { get; set; }
        public string Phone { get; set; }

    }
}
