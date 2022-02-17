using System.Text;
namespace voting
{
    public class Candidate
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string NameParty { get; set; }

        public Candidate()
        {

        }

        public Candidate(int id, string name, string nameParty)
        {
            this.Id = id;
            this.Name = name;
            this.NameParty = nameParty;
        }
        public override string ToString()
        {
            StringBuilder allInformation = new StringBuilder();
            allInformation.Append("ID: ");
            allInformation.AppendLine(Id.ToString());
            allInformation.Append("Name of Mayor: ");
            allInformation.AppendLine(Name);
            allInformation.Append("Name of Party: ");
            allInformation.AppendLine(NameParty);
            return allInformation.ToString();
        }
    }

}
