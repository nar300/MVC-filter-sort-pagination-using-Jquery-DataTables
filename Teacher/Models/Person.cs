using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teacher.Models
{
    public class Person
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public bool IsChecked { get; set; }
    }
}