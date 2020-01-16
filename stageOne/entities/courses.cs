using System;

namespace SchoolProy.entities{
    public class Courses{
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public journeys Journey { get; set; }

        // COnstructor:
        public Courses() => this.UniqueId = Guid.NewGuid().ToString();
    }
}