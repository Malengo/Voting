namespace voting
{
    public class Voter
    {
        private int Id { get; set; }
        private int Password { get; set; }
        public string Name { get; set; }

        public Voter(){}
        public Voter(int id, int password, string name)
        {
            this.Id = id;
            this.Password = password;
            this.Name = name;

        }
        public Boolean validate(int pass){
            return this.Password.Equals(pass);
        }
       
    }
}



