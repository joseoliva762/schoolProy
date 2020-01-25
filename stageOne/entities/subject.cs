using System;
namespace CoreSchool.entities{
    public class Subject{
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        // COnstructor:
        public Subject() => this.UniqueId = Guid.NewGuid().ToString();
    }
}