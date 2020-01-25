using System;
namespace CoreSchool.entities{
    public class Evaluation{
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public float Score { get; set; }

        // COnstructor:
        public Evaluation() => this.UniqueId = Guid.NewGuid().ToString();
    }
}