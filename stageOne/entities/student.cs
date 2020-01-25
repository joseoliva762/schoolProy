using System;
namespace CoreSchool.entities{
    public class Student{
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        // COnstructor:
        public Student() => this.UniqueId = Guid.NewGuid().ToString();
    }
}