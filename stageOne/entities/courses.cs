using System;
using System.Collections.Generic;


namespace CoreSchool.entities{
    public class Courses{
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public journeys Journey { get; set; }
        public List<Subject> Subjects{ get; set; }
        public List<Student> Students{ get; set; }
        // COnstructor:
        public Courses() => this.UniqueId = Guid.NewGuid().ToString();
    }
}