using System;
using System.ComponentModel.DataAnnotations;

namespace CloudCraftHistory.Models
{
    public class Member
    {

        /* Personal Information */ 
        public int ID { get; set; }
        public string Username { get; set; }

        [Display(Name = "Name")]
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
        [Display(Name = "2014")]
        public int fourteen { get; set; }
        [Display(Name = "2015")]
        public int fifteen { get; set; }
        [Display(Name = "2016")]
        public int sixteen { get; set; }
        [Display(Name = "2017")]
        public int seventeen { get; set; }
        [Display(Name = "2018")]
        public int eighteen { get; set; }
        [Display(Name = "2019")]
        public int nineteen { get; set; }
        [Display(Name = "2020")]
        public int twenty { get; set; }
        [Display(Name = "2021")]
        public int twentyone { get; set; }

    }
}
