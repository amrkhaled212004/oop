using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oop
{
    public class player : reff
    {

        public string pos;

        public player(string name, string nat, int age, string pos) : base(name, nat, age)
        {
            this.name = name;
            this.pos = pos;
            this.nat = nat;
            this.age = age;
        }
    }
    public class team
    {
        public string name;
        public team(string name)
        {
            this.name = name;
        }
    }
    public class reff
    {
        public string name;
        public string nat;
        public int age;
        public reff(string name, string nat, int age)
        {
            this.name = name;
            this.nat = nat;
            this.age = age;
        }
    }
    public class match
    {
        public team HomeTeam { get; set; }
        public team AwayTeam { get; set; }
        public stadium Stadium { get; set; }
        public reff Referee { get; set; }
        public match(team HomeTeam, team AwayTeam, stadium stadium, reff Refferee)
        {
            this.HomeTeam = HomeTeam;
            this.Referee = Referee;
            this.AwayTeam = AwayTeam;
            this.Stadium = Stadium;
        }
    }
    public class Admin
    {

        private static string username = "amr";
        private static string password = "4748";
        public bool Authentication(string N, string P)
        {
            if (string.IsNullOrEmpty(N)) return false;
            if (string.IsNullOrEmpty(P)) return false;
            if (N == username && P == password) return true;
            else return false;

        }
        public Admin() { }

    }

    public class stadium
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int SeatCapacity { get; set; }

        public stadium(string Name, string Locaion, int SeatCapacity)
        {
            this.Name = Name;
            this.Location = Locaion;
            this.SeatCapacity = SeatCapacity;

        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            List<team> teams = new List<team>();
            List<player> player = new List<player>();
            List<reff> referees = new List<reff>();
            List<stadium> stadiums = new List<stadium>();
            List<match> match = new List<match>();

            teams.Add(new team("real madrid"));
            teams.Add(new team("barca"));
            teams.Add(new team("liver"));

            referees.Add(new reff("ahmed", "Egypt", 40));
            referees.Add(new reff("mohamed", "Egypt", 35));
            referees.Add(new reff("ali", "Egypt", 38));
            player.Add(new player("ali", "egy", 25, "gk"));
            player.Add(new player("Mohamed", "egy", 20, "cb"));
            player.Add(new player("yehia", "egy", 25, "st"));
            player.Add(new player("marwan", "egy", 35, "gk"));
            player.Add(new player("ussef", "egy", 19, "cb"));
            player.Add(new player("hosny", "egy", 30, "st"));
            player.Add(new player("amr", "egy", 22, "gk"));
            player.Add(new player("ibrahim", "egy", 25, "cb"));
            player.Add(new player("bodda", "egy", 27, "st"));
            stadiums.Add(new stadium("ber", "london", 10000));
            stadiums.Add(new stadium("san", "usa", 20000));
            stadiums.Add(new stadium("arb", "egypt", 10000));
            team homeTeam = teams[0]; // Example: Real Madrid
            team awayTeam = teams[1]; // Example: Barca
            reff matchReferee = referees[0]; // Example: Ahmed
            stadium matchStadium = stadiums[0]; // Example: "ber"
                                                // Create additional matches and add them to the matches list
            team homeTeam2 = teams[1]; // Example: Barca
            team awayTeam2 = teams[2]; // Example: Liverpool
            reff matchReferee2 = referees[1]; // Example: Mohamed
            stadium matchStadium2 = stadiums[1]; // Example: "san"

            match newMatch2 = new match(homeTeam2, awayTeam2, matchStadium2, matchReferee2);
            match.Add(newMatch2);

            team homeTeam3 = teams[2]; // Example: Liverpool
            team awayTeam3 = teams[0]; // Example: Real Madrid
            reff matchReferee3 = referees[2]; // Example: Ali
            stadium matchStadium3 = stadiums[2]; // Example: "arb"

            match newMatch3 = new match(homeTeam3, awayTeam3, matchStadium3, matchReferee3);
            match.Add(newMatch3);

            team homeTeam4 = teams[0]; // Example: Real Madrid
            team awayTeam4 = teams[1]; // Example: Barca
            reff matchReferee4 = referees[0]; // Example: Ahmed
            stadium matchStadium4 = stadiums[0]; // Example: "ber"

            match newMatch4 = new match(homeTeam4, awayTeam4, matchStadium4, matchReferee4);
            match.Add(newMatch4);








            Admin admin = new Admin();
            while (true)
            {
                Console.WriteLine("1- user\n2- admin");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Which data would you like to display?");
                        Console.WriteLine("1. Players");
                        Console.WriteLine("2. Teams");
                        Console.WriteLine("3. Stadiums");
                        Console.WriteLine("4. Referees");

                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Players:");
                                foreach (var pr in player)
                                {
                                    Console.WriteLine($"  Name: {pr.name}, Position: {pr.pos}, Nationality: {pr.nat}, Age: {pr.age}");
                                }


                                break;
                            case 2:
                                Console.WriteLine("Teams:");
                                foreach (var team in teams)
                                {
                                    Console.WriteLine($" Name: {team.name}");
                                }

                                break;
                            case 3:
                                Console.WriteLine("Stadiums:");
                                foreach (var stadium in stadiums)
                                {
                                    Console.WriteLine($" Name: {stadium.Name}, Location: {stadium.Location}, Seat Capacity: {stadium.SeatCapacity}");

                                }

                                break;
                            case 4:
                                Console.WriteLine("Referees:");
                                foreach (var referee in referees)
                                {
                                    Console.WriteLine($", Name: {referee.name}, Nationality: {referee.nat}, Age: {referee.age}");

                                }

                                break;
                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;


                    case 2:
                        Console.Clear();

                        string u;
                        string p;
                        bool authenticated = false;

                        do
                        {
                            Console.WriteLine("username:");
                            u = Console.ReadLine();
                            Console.WriteLine("password:");
                            p = Console.ReadLine();
                            authenticated = admin.Authentication(u, p);
                            if (!authenticated)
                            {
                                Console.WriteLine("Wrong username or password");
                            }
                        } while (!authenticated);

                        Console.Clear();
                        Console.WriteLine("login succesfully\n");
                        Console.WriteLine("1-add\n 2-delete\n 3-display\n");
                        int l = Convert.ToInt32(Console.ReadLine());
                        switch (l)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("1-team\n 2-player\n 3-stadium \n 4-referee\n5-match");
                                int g = Convert.ToInt32(Console.ReadLine());
                                switch (g)
                                {
                                    case 1:
                                        Console.WriteLine("enter team name");
                                        string x = Console.ReadLine();
                                        team teamname = new team(x);

                                        teams.Add(teamname);
                                        

                                        for (int i = 0; i < 3; i++)
                                        {

                                            Console.WriteLine("enter player name");
                                            string pnamee = Console.ReadLine();


                                            Console.WriteLine("enter nat");
                                            string pnat = Console.ReadLine();
                                            Console.WriteLine("enter age");
                                            int pagee = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("enter pos");
                                            string pposi = Console.ReadLine();
                                            player pplay = new player(pnamee, pnat, pagee, pposi);
                                            player.Add(pplay);
                                            Console.Clear();
                                        }
                                        Console.WriteLine("enter stadium name");
                                        string sname = Console.ReadLine();
                                        Console.WriteLine("enter stadium location");
                                        string sloc = Console.ReadLine();
                                        Console.WriteLine("enter stadium capacity");
                                        int scap = Convert.ToInt32(Console.ReadLine());

                                        stadium stadium = new stadium(sname, sloc, scap);
                                        stadiums.Add(stadium);
                                        Console.WriteLine("team add is suc");
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("if you add a player you must remove another one");
                                        int plaindex = -1; // Initialize index to -1 initially
                                        string plastad = "";


                                        do
                                        {
                                            Console.WriteLine("Enter the name of the player you will del:");
                                            plastad = Console.ReadLine();


                                            plaindex = player.FindIndex(s => s.name.Equals(plastad, StringComparison.OrdinalIgnoreCase));
                                            if (plaindex == -1)
                                            {
                                                Console.WriteLine("this stadium is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (plaindex == -1);
                                        player.RemoveAt(plaindex);
                                        Console.WriteLine("enter new player name");
                                        string namee = Console.ReadLine();
                                 
                                        Console.WriteLine("enter nat");
                                        string nat = Console.ReadLine();
                                        Console.WriteLine("enter age");
                                        int agee = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("enter pos");
                                        string posi = Console.ReadLine();
                                        player play = new player(namee, nat, agee, posi);
                                        player.Insert(plaindex, play);


                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("do you want to replace a stadium");
                                        string yes = Console.ReadLine();
                                        if (yes == "yes")
                                        {

                                            int repindex = -1; // Initialize index to -1 initially
                                            string repstad = "";
                                            do
                                            {
                                                Console.WriteLine("Enter the name of the stadium:");
                                                repstad = Console.ReadLine();


                                                repindex = stadiums.FindIndex(s => s.Name.Equals(repstad, StringComparison.OrdinalIgnoreCase));
                                                if (repindex == -1)
                                                {
                                                    Console.WriteLine("this stadium is not correct try again");
                                                    Console.Clear();
                                                }



                                            } while (repindex == -1);
                                            stadiums.RemoveAt(repindex);

                                            Console.WriteLine("enter stadium name");
                                            string repname = Console.ReadLine();
                                            Console.WriteLine("enter stadium location");
                                            string reploc = Console.ReadLine();
                                            Console.WriteLine("enter stadium capacity");
                                            int repcap = Convert.ToInt32(Console.ReadLine());

                                            stadium repstadium = new stadium(repname, reploc, repcap);
                                            stadiums.Insert(repindex, repstadium);
                                            Console.WriteLine("stadium data added succesfully");




                                        }

                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("enter reff name");
                                        string refname = Console.ReadLine();
                                        Console.WriteLine("enter reff nat");
                                        string refnat = Console.ReadLine();
                                        Console.WriteLine("enter reff age");
                                        int refage = Convert.ToInt32(Console.ReadLine());
                                        reff reff = new reff(refname, refnat, refage);
                                        referees.Add(reff);
                                        Console.WriteLine("referee data added succesfully");


                                        break;
                                    case 5:
                                        Console.Clear();

                                        int team1index = -1; // Initialize index to -1 initially
                                        string team1stad = "";


                                        do
                                        {
                                            Console.WriteLine("Enter the first team name:");
                                            team1stad = Console.ReadLine();


                                            team1index = teams.FindIndex(t => t.name.Equals(team1stad, StringComparison.OrdinalIgnoreCase));
                                            if (team1index == -1)
                                            {
                                                Console.WriteLine("this team doesn't exist try again");
                                                Console.Clear();
                                            }



                                        } while (team1index == -1);


                                        int team2index = -1; // Initialize index to -1 initially
                                        string team2stad = "";
                                        do
                                        {
                                            Console.WriteLine("Enter the second team name:");
                                            team2stad = Console.ReadLine();


                                            team2index = teams.FindIndex(t => t.name.Equals(team2stad, StringComparison.OrdinalIgnoreCase));
                                            if (team2index == -1)
                                            {
                                                Console.WriteLine("this team doesn't exist try again");
                                                Console.Clear();
                                            }



                                        } while (team2index == -1);

                                        int staindex = -1; // Initialize index to -1 initially
                                        string stastad = "";
                                        do
                                        {
                                            Console.WriteLine("Enter the name of the stadium:");
                                            stastad = Console.ReadLine();


                                            staindex = stadiums.FindIndex(s => s.Name.Equals(stastad, StringComparison.OrdinalIgnoreCase));
                                            if (staindex == -1)
                                            {
                                                Console.WriteLine("this stadium is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (staindex == -1);
                                        int reffindex = -1; // Initialize index to -1 initially
                                        string refftad = "";
                                        do
                                        {
                                            Console.WriteLine("Enter the name of the referee:");
                                            refftad = Console.ReadLine();


                                            reffindex = referees.FindIndex(r => r.name.Equals(refftad, StringComparison.OrdinalIgnoreCase));
                                            if (staindex == -1)
                                            {
                                                Console.WriteLine("this reff is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (reffindex == -1);
                                        match match1 = new match(teams[team1index], teams[team2index], stadiums[staindex], referees[reffindex]);

                                        match.Add(match1);
                                        break;


                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("1-team\n 2-player\n 3-stadium \n 4-referee\n5-match");
                                int z = Convert.ToInt32(Console.ReadLine());
                                switch (z)
                                {
                                    case 1:

                                        int team1index = -1; // Initialize index to -1 initially
                                        string team1stad = "";


                                        do
                                        {
                                            Console.WriteLine("Enter the name of the team:");
                                            team1stad = Console.ReadLine();


                                            team1index = teams.FindIndex(s => s.name.Equals(team1stad, StringComparison.OrdinalIgnoreCase));
                                            if (team1index == -1)
                                            {
                                                Console.WriteLine("this stadium is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (team1index == -1);
                                        teams.RemoveAt(team1index);
                                        stadiums.RemoveAt(team1index);
                                        int removeplayers = ((team1index + 1) * 3);
                                        for (int i = ((1 + team1index) * 3) - 3; i < removeplayers; i++)
                                        {
                                            player.RemoveAt(i);
                                        }



                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("if you deleted a player you must add another one");
                                        int plaindex = -1; // Initialize index to -1 initially
                                        string plastad = "";


                                        do
                                        {
                                            Console.WriteLine("Enter the name of the player:");
                                            plastad = Console.ReadLine();


                                            plaindex = player.FindIndex(s => s.name.Equals(plastad, StringComparison.OrdinalIgnoreCase));
                                            if (plaindex == -1)
                                            {
                                                Console.WriteLine("this player is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (plaindex == -1);
                                        player.RemoveAt(plaindex);
                                        Console.WriteLine("enter new player name");
                                        string namee = Console.ReadLine();
                                        Console.WriteLine("enter pos");
                                        string pos = Console.ReadLine();
                                        Console.WriteLine("enter nat");
                                        string nat = Console.ReadLine();
                                        Console.WriteLine("enter age");
                                        int agee = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("enter pos");
                                        string posi = Console.ReadLine();
                                        player play = new player(namee, nat, agee, posi);
                                        player.Insert(plaindex, play);


                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("if you deleted this stadium you must insert another one");
                                        int stadindex = -1; // Initialize index to -1 initially
                                        string stadstad = "";


                                        do
                                        {
                                            Console.WriteLine("Enter the name of the stadium you will del:");
                                            stadstad = Console.ReadLine();


                                            stadindex = stadiums.FindIndex(s => s.Name.Equals(stadstad, StringComparison.OrdinalIgnoreCase));
                                            if (stadindex == -1)
                                            {
                                                Console.WriteLine("this stadium is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (stadindex == -1);
                                        stadiums.RemoveAt(stadindex);
                                        Console.WriteLine("enter stadium name");
                                        string repname = Console.ReadLine();
                                        Console.WriteLine("enter stadium location");
                                        string reploc = Console.ReadLine();
                                        Console.WriteLine("enter stadium capacity");
                                        int repcap = Convert.ToInt32(Console.ReadLine());

                                        stadium repstadium = new stadium(repname, reploc, repcap);
                                        stadiums.Insert(stadindex, repstadium);


                                        break;
                                    case 4:
                                        int reffindex = -1; // Initialize index to -1 initially
                                        string reffstad = "";


                                        do
                                        {
                                            Console.WriteLine("Enter the name of the reff:");
                                            reffstad = Console.ReadLine();


                                            reffindex = referees.FindIndex(s => s.name.Equals(reffstad, StringComparison.OrdinalIgnoreCase));
                                            if (reffindex == -1)
                                            {
                                                Console.WriteLine("this reff is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (reffindex == -1);
                                        referees.RemoveAt(reffindex);

                                        break;
                                    case 5:
                                        Console.Clear();
                                        int team1index1 = -1; // Initialize index to -1 initially
                                        string team1stad1 = "";


                                        do
                                        {
                                            Console.WriteLine("Enter the name of the home  team1:");
                                            team1stad1 = Console.ReadLine();


                                            team1index1 = teams.FindIndex(s => s.name.Equals(team1stad1, StringComparison.OrdinalIgnoreCase));
                                            if (team1index1 == -1)
                                            {
                                                Console.WriteLine("this stadium is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (team1index1 == -1);

                                        int team2index2 = -1; // Initialize index to -1 initially
                                        string team2stad2 = "";
                                        do
                                        {
                                            Console.WriteLine("Enter the name of the away team:");
                                            team2stad2 = Console.ReadLine();


                                            team2index2 = teams.FindIndex(s => s.name.Equals(team2stad2, StringComparison.OrdinalIgnoreCase));
                                            if (team2index2 == -1)
                                            {
                                                Console.WriteLine("this team is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (team2index2 == -1);

                                        int staindex = -1; // Initialize index to -1 initially
                                        string stastad = "";
                                        do
                                        {
                                            Console.WriteLine("Enter the name of the stadium:");
                                            stastad = Console.ReadLine();


                                            staindex = stadiums.FindIndex(s => s.Name.Equals(stastad, StringComparison.OrdinalIgnoreCase));
                                            if (staindex == -1)
                                            {
                                                Console.WriteLine("this stadium is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (staindex == -1);
                                        int refindex = -1; // Initialize index to -1 initially
                                        string reftad = "";
                                        do
                                        {
                                            Console.WriteLine("Enter the name of the stadium:");
                                            reftad = Console.ReadLine();


                                            refindex = referees.FindIndex(s => s.name.Equals(reftad, StringComparison.OrdinalIgnoreCase));
                                            if (refindex == -1)
                                            {
                                                Console.WriteLine("this reff is not correct try again");
                                                Console.Clear();
                                            }



                                        } while (refindex == -1);
                                        match match1 = new match(teams[team1index1], teams[team2index2], stadiums[staindex], referees[refindex]);
                                        int location = 0;

                                        // Iterate through the linked list
                                        foreach (match currentmatch in match)
                                        {
                                            if (currentmatch == match1)
                                                break;
                                            else
                                                location++;
                                        }
                                        match.RemoveAt(location);
                                        break;
                                }

                                break;
                            case 3:


                                Console.Clear();
                                Console.WriteLine("Which data would you like to display?");
                                Console.WriteLine("1. Players");
                                Console.WriteLine("2. Teams");
                                Console.WriteLine("3. Stadiums");
                                Console.WriteLine("4. Referees");

                                int c = Convert.ToInt32(Console.ReadLine());

                                switch (c)
                                {
                                    case 1:
                                        Console.WriteLine("Players:");
                                        foreach (var pr in player)
                                        {
                                            Console.WriteLine($"  Name: {pr.name}, Position: {pr.pos}, Nationality: {pr.nat}, Age: {pr.age}");
                                        }


                                        break;
                                    case 2:
                                        Console.WriteLine("Teams:");
                                        foreach (var team in teams)
                                        {
                                            Console.WriteLine($" Name: {team.name}");
                                        }

                                        break;
                                    case 3:
                                        Console.WriteLine("Stadiums:");
                                        foreach (var stadium in stadiums)
                                        {
                                            Console.WriteLine($" Name: {stadium.Name}, Location: {stadium.Location}, Seat Capacity: {stadium.SeatCapacity}");

                                        }

                                        break;
                                    case 4:
                                        Console.WriteLine("Referees:");
                                        foreach (var referee in referees)
                                        {
                                            Console.WriteLine($", Name: {referee.name}, Nationality: {referee.nat}, Age: {referee.age}");

                                        }

                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice.");
                                        break;
                                }
                                break;















                        }


                        break;

                }
                Console.ReadLine();
                Console.Clear() ;


            }
        }

    }

}