// See https://aka.ms/new-console-template for more information
using voting;
using voting.entites;


Election election= new Election();
char option;
do
{
    Console.Write("Please enter to id of Mayor: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Please Enter the Name of Mayor: ");
    string name = Console.ReadLine();
    Console.Write("Please enter NameParty of Mayor: ");
    string nameParty = Console.ReadLine();
    election.addCandidate(new Candidate(id, name, nameParty));
    Console.Write("Do you want to add more Mayors for vote Y or N: ");
    option = char.Parse(Console.ReadLine().ToUpper());
} while (option.Equals('Y'));

do
{
    Console.Write("Please enter to id of Voter: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Please enter your Password: ");
    int password = int.Parse(Console.ReadLine());
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    election.addVoter(new Voter(id, password, name));
    Console.Write("Do you want to add more Voter Y or N: ");
    option = char.Parse(Console.ReadLine().ToUpper());


} while (option.Equals('Y'));

/*foreach (Candidate mayors in election.Candidates)
{
    Console.WriteLine(mayors.ToString());
}*/

Console.Write("Please Enter Your Name for voting");
string nameVoter = Console.ReadLine();
Console.Write("Please Enter Your Password: ");
int passwordVoter = int.Parse(Console.ReadLine());
if(election.validateVoter(passwordVoter, nameVoter)){
    Console.WriteLine("You're eligible for voting");
}else{
    Console.WriteLine("Your name or password is incorrect: ");
}

