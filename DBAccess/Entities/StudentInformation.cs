using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBAccess.Entities
{
    internal class StudentInformation
    {
        public int Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string ImageName { get; set; }
        public int countryId { get; set; }
        public int stateId { get; set; }
        public int cityId { get; set; }
        public DateTime createdDate { get; set; }
    }

    public class Subject
    {
        public int Id { get; set; }
        public string subjectName { get; set; }
        public string subjectDescription { get; set; }
       
        
    }
}
