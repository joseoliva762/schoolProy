namespace SchoolProy.entities{
    class Schools{
        //Atributo.
        private string name;
        //getters and setters
        public string Name{ //Propiedad.
            get{ return name; }
            set{ name = value; }
        }

        public int Fundation{ get; set; } //Inicializa mi variable automaticamente.
        public string Country { get; set; }
        public string City { get; set; }
        public string Ceo { get; set; }

        public schoolTypes schoolType { get; set; }
        //Métodos.
        //Constructor:
        public Schools(string name, string ceo){
            this.name = name;
            this.Ceo = ceo;
            // Tambien: public Schools(string name, string ceo) => (Name, Ceo) = (name, ceo);
        }

        //Sobre carga
        public Schools(string name, string ceo,
                        int fundation, schoolTypes schoolType,
                        string city="", string country = "Colombia"){
            this.Name = name;
            this.Ceo = ceo;
            this.Fundation = fundation;
            this.City = city;
            this.schoolType = schoolType;
            this.Country = country;
        }

        public override string ToString(){
            string toStringReturn = $"Data of \"{base.ToString()}\":\n \tName: {this.Name}.\n \tSchool Type: {this.schoolType}.\n \tCEO: {this.Ceo}.\n \tFundation: {this.Fundation}.\n \tCounty: {this.Country}.\n \tCity: {this.City}.\n";
            return toStringReturn;
        }

        
    }
}
