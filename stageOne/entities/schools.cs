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
        
        //Métodos.
        //Constructor:
        public Schools(string name, string ceo){
            this.name = name;
            this.Ceo = ceo;
            // Tambien: public Schools(string name, string ceo) => (Name, Ceo) = (name, ceo);
        }


        
    }
}
