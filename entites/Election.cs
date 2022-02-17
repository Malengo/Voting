namespace voting.entites
{
    public class Election
    {
        private List<Voter> Voters { get; set; } = new List<Voter>();
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();

        public Election() { }
        public void addVoter(Voter voters)
        {
            Voters.Add(voters);
        }

        public void addCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }

        public bool validateVoter(int password, string name){
            bool accept = false;
            foreach(Voter voters in Voters){
                if(voters.Name.Equals(name)){
                    if(voters.validate(password)){
                        accept= true;
                        break;
                    }else{
                        break;
                    }
                }

            }
            return accept;
        }
    }
}
