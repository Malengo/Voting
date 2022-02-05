namespace voting
{
    public class Voter
    {
        private int Id { get; set; }
        private int Password { get; set; }
        private string Name { get; set; }

        public Voter(){}
        public Voter(int id, int password, string name)
        {
            this.Id = id;
            this.Password = password;
            this.Name = name;

        }
       
    }
}



