// See https://aka.ms/new-console-template for more information
using voting;

List<Candidate> candidates = new List<Candidate>();
List<Voter> voters = new List<Voter>();
char option;
do
{
    Console.Write("Please enter to id of Mayor: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Please Enter the Name of Mayor: ");
    string name = Console.ReadLine();
    Console.Write("Please enter NameParty of Mayor: ");
    string nameParty = Console.ReadLine();
    candidates.Add(new Candidate(id, name, nameParty));
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
    voters.Add(new Voter(id, password, name));
    Console.Write("Do you want to add more Voter Y or N: ");
    option = char.Parse(Console.ReadLine().ToUpper());


} while (option.Equals('Y'));

foreach (Candidate mayors in candidates)
{
    Console.WriteLine(mayors.ToString());
}

