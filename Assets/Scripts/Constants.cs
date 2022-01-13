using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants
{
    public List<Job> jobList = new List<Job>();

    public RealEstate
        carp = new RealEstate("Carp", 0, "Simple and free.", -1, -1);

    public RealEstate
        farm =
            new RealEstate("Farm",
                2,
                "Living along the cows and horses... At least there is a roof..",
                -1,
                0);

    public RealEstate
        tavern =
            new RealEstate("Tavern",
                5,
                "A sweet tavern, full of beer and travellers..",
                1,
                0);

    public RealEstate
        cabin = new RealEstate("Cabin", 10, "The vermintide dream.", 1, 1);

    // The Business Instantations
    public Business
        securityCompany = new Business("SecurityCompany", 500, 0, 1, 10, 50);

    public Business
        alchemyCompany = new Business("Alchemy", 1000, 0, 2, 20, 110);

    public Business
        travelMerchant = new Business("Travel Merchant", 2000, 0, 1, 8, 250);

    // List of Random Logs
    public LogsList aventurerLogs = new LogsList("Aventurer");

    // public LogsList socialLogs = new LogsList("Social");
    public int startingYear = 823;

    public Items items = new Items();

    public Constants()
    {
        createJobs();
        createLogs();
    }

    public void createLogs()
    {
        // Aventurer Logs Added
        aventurerLogs
            .logList
            .Add(new Log("You are being hunted!",
                1,
                "A roar emerges behind you, a wild beast starts pursuing you!",
                "@choice \"Fence him off\" set:p_health-=10;p_stat_str+=1 \n@choice \"Run!\"",
                "event1"));
        aventurerLogs
            .logList
            .Add(new Log("You are challanged into a duel",
                1,
                "A warrior approaches to you. He gracefully invites you to fight against him.",
                "@choice \"Accept the challange\" set:p_health-=10;p_fame+=10 \n@choice \"Refuse\" set:p_happiness-=10;p_fame-=10",
                "event1"));
        aventurerLogs
            .logList
            .Add(new Log("You witness a magnificent view ",
                1,
                "This is what life is about...",
                "@choice \"Enjoy the view.\" set:p_happiness+=10",
                "event1"));
        aventurerLogs
            .logList
            .Add(new Log("Ouch",
                2,
                "You fall into a booby trap",
                "@choice \"disable the booby trap\" set:item_boobytrap+=1;p_health-=20",
                "event1"));
        aventurerLogs
            .logList
            .Add(new Log("Kidnapping!",
                2,
                "One of your teammates had been kidnapped...",
                "@choice \"Pay ransom\" set:p_money-=100"));
        aventurerLogs
            .logList
            .Add(new Log("Rotten food",
                2,
                "You got poisoned by eating rotten food ",
                "@choice \"Do nothing.\" set:p_health-=20\n@choice \"Buy Medicine\"",
                "event1"));
        aventurerLogs.logList.Add(new Log("They leave you a handsome tip!", 2));
        aventurerLogs.logList.Add(new Log("Chaos Warrior Challanges you", 2));
        aventurerLogs.logList.Add(new Log("Short Cut found", 2));
        aventurerLogs
            .logList
            .Add(new Log("The town celebrates you as a hero", 3));
        aventurerLogs.logList.Add(new Log("Drunk Fight", 2));
        aventurerLogs.logList.Add(new Log("Ally falls in battle", 2));
        aventurerLogs
            .logList
            .Add(new Log("Magic dissaster shakes the kingdom", 3));
        aventurerLogs.logList.Add(new Log("Goblin Slayer?", 3));
    }

    public void createJobs()
    {
        List<JobRank> farmerJobRanks = new List<JobRank>();
        farmerJobRanks.Add(new JobRank(10, "Serf"));
        farmerJobRanks.Add(new JobRank(15, "Herder"));
        farmerJobRanks.Add(new JobRank(20, "Senior"));
        farmerJobRanks.Add(new JobRank(30, "Administrator"));

        List<JobRank> aventurerJobRanks = new List<JobRank>();
        aventurerJobRanks.Add(new JobRank(10, "Porcelain"));
        aventurerJobRanks.Add(new JobRank(18, "Obsidian"));
        aventurerJobRanks.Add(new JobRank(24, "Steel"));
        aventurerJobRanks.Add(new JobRank(35, "Emerald"));
        aventurerJobRanks.Add(new JobRank(55, "Ruby"));
        aventurerJobRanks.Add(new JobRank(85, "Bronze"));
        aventurerJobRanks.Add(new JobRank(120, "Silver"));
        aventurerJobRanks.Add(new JobRank(200, "Gold"));
        aventurerJobRanks.Add(new JobRank(300, "Platinum"));

        List<JobRank> CivilServantJobRanks = new List<JobRank>();
        CivilServantJobRanks.Add(new JobRank(20, "Bookbinder"));
        CivilServantJobRanks.Add(new JobRank(25, "Scholar"));
        CivilServantJobRanks.Add(new JobRank(30, "Officer"));
        CivilServantJobRanks.Add(new JobRank(40, "Assistant Attache"));
        CivilServantJobRanks.Add(new JobRank(50, "Attache"));
        CivilServantJobRanks.Add(new JobRank(85, "Secretary"));
        CivilServantJobRanks.Add(new JobRank(100, "Minister"));
        CivilServantJobRanks.Add(new JobRank(120, "Counsellor"));

        List<JobRank> tradesmanJobRanks = new List<JobRank>();
        tradesmanJobRanks.Add(new JobRank(10, "Carpenter Apprentice"));
        tradesmanJobRanks.Add(new JobRank(20, "Carpenter"));
        tradesmanJobRanks.Add(new JobRank(35, "Master Carpenter"));
        tradesmanJobRanks.Add(new JobRank(55, "Mason"));
        tradesmanJobRanks.Add(new JobRank(75, "Engineer"));
        tradesmanJobRanks.Add(new JobRank(90, "Master Engineer"));

        List<JobRank> mercenaryJobRanks = new List<JobRank>();
        mercenaryJobRanks.Add(new JobRank(17, "Enlistee"));
        mercenaryJobRanks.Add(new JobRank(22, "Private"));
        mercenaryJobRanks.Add(new JobRank(32, "Lance Corporal"));
        mercenaryJobRanks.Add(new JobRank(42, "Corporal"));
        mercenaryJobRanks.Add(new JobRank(62, "Sargeant"));
        mercenaryJobRanks.Add(new JobRank(87, "Lieutenant"));
        mercenaryJobRanks.Add(new JobRank(122, "Captain"));
        mercenaryJobRanks.Add(new JobRank(185, "Major"));
        mercenaryJobRanks.Add(new JobRank(240, "Colonel"));

        List<JobRank> merchantJobRanks = new List<JobRank>();
        merchantJobRanks.Add(new JobRank(5, "Peddler"));
        merchantJobRanks.Add(new JobRank(8, "Dealer"));
        merchantJobRanks.Add(new JobRank(15, "Merchant Apprentice"));
        merchantJobRanks.Add(new JobRank(30, "Merchant"));
        merchantJobRanks.Add(new JobRank(50, "Broker"));
        merchantJobRanks.Add(new JobRank(80, "Entrepreneur"));
        merchantJobRanks.Add(new JobRank(120, "Tycoon"));

        List<JobRank> soldierJobRanks = new List<JobRank>();
        soldierJobRanks.Add(new JobRank(10, "Enlistee"));
        soldierJobRanks.Add(new JobRank(15, "Private"));
        soldierJobRanks.Add(new JobRank(25, "Lance Corporal"));
        soldierJobRanks.Add(new JobRank(35, "Corporal"));
        soldierJobRanks.Add(new JobRank(45, "Sargeant"));
        soldierJobRanks.Add(new JobRank(65, "Lieutenant"));
        soldierJobRanks.Add(new JobRank(90, "Captain"));
        soldierJobRanks.Add(new JobRank(125, "Major"));
        soldierJobRanks.Add(new JobRank(190, "Colonel"));
        soldierJobRanks.Add(new JobRank(260, "General"));

        // TODO: OTHER JOBS CLEAN
        // jobList.Add(new Job("Farmer", farmerJobRanks));
        jobList.Add(new Job("Aventurer", aventurerJobRanks));

        // jobList.Add(new Job("Civil Servant", CivilServantJobRanks));
        // getJobFromName("Civil Servant").setSpecificToNobilityRequired(new int[] { 4, 5, 6, 7 });
        // jobList.Add(new Job("Trades", tradesmanJobRanks));
        // jobList.Add(new Job("Mercenary", mercenaryJobRanks));
        jobList.Add(new Job("Merchant", merchantJobRanks));
        jobList.Add(new Job("Soldier", soldierJobRanks));
        // getJobFromName("Soldier").setSpecificToNobilityRequired(new int[] { 4, 5, 6, 7, 8, 9 });
    }

    public void createItems()
    {
    }

    public Job getJobFromName(string jobName)
    {
        return jobList
            .Find(delegate (Job jk)
            {
                return jk.careerTitle == jobName;
            });
    }
}

public class RandomGenerator
{
    public string[]
        humanMalesNamesDatabase =
            new string[] {
                "Herbert Teske",
                "Buster Kluck",
                "Abe Austin",
                "Marcos Woodrum",
                "Diego Riddell",
                "Thomas Hoglund",
                "Darryl Cardamone",
                "Erick Brockwell",
                "Odell Provencher",
                "Scotty Leo",
                "Gordon Frankum",
                "Kelly Visitacion",
                "Ronald Varley",
                "Cedric Clukey",
                "Mariano Sumners",
                "Tomas Ensey",
                "Curt Sandberg",
                "Keenan Teasdale",
                "Jorge Paulus",
                "Adrian Weatherby",
                "Val Kosak",
                "Carson Trickett",
                "Newton Swinson",
                "Stevie Huss",
                "Faustino Gushiken",
                "Henry Adkins",
                "Weston Koenig",
                "Harland Hoisington",
                "Brenton Ohern",
                "Kasey Hadlock",
                "Marcellus Manns",
                "Carrol Gower",
                "Marquis Rothchild",
                "Alex Lamere",
                "Whitney Mcmonagle",
                "Donnell Ladson",
                "Gregg Plascencia",
                "Raul Pryce",
                "Dylan Flock",
                "Milton Porras",
                "Moshe Cress",
                "Chris Lacoste",
                "Santos Richard",
                "Jeffrey Blosser",
                "Jeffery Aman",
                "Tyler Tunstall",
                "Don Stollings",
                "Andrea Schall",
                "Vernon Schroeter",
                "Mohammed Wada",
                "Anibal Dixson",
                "Gerry Butner",
                "Benny Domingue",
                "Marc Visser",
                "Hobert Bachus",
                "Nolan Marshburn",
                "Lamont Rollings",
                "Len Toto",
                "Maria Screen",
                "Tod Jeppesen",
                "Octavio Dennard",
                "Lester Eutsey",
                "Colin Silveria",
                "Lawerence Matias",
                "Joel Dibernardo",
                "Luther Rhynes",
                "Luigi Delossantos",
                "Sherwood Chattin",
                "Frederic Haycock",
                "Dee Dillard",
                "Cletus Bills",
                "Scott Alper",
                "Angelo Francois",
                "Roscoe Echevarria",
                "Taylor Gary",
                "Jaime Howey",
                "Orville Haskin",
                "Pablo Chisholm",
                "Roland Gosse",
                "Blake Silverio",
                "Rory Whorley",
                "Grant Fabiano",
                "Stevie Fishburn",
                "Robbie Gobeil",
                "Elliot Nyland",
                "Terry Broadfoot",
                "Maynard Klick",
                "Modesto Welch",
                "Amado Wilmes",
                "Zack Jolliff",
                "Irving Raschke",
                "Gus Fogal",
                "Kenneth Sheahan",
                "Efrain Musser",
                "Milton Corson",
                "Trey Kelm",
                "Kenny Meals",
                "Quinn Daye",
                "Wilford Niel",
                "Asa Hawbaker",
                "Maynard Lathan",
                "Ike Mickel",
                "Dirk Carbajal",
                "Leandro Faries",
                "Angelo Shook",
                "Myron Furrow",
                "Leslie Maselli",
                "Brain Gulyas",
                "Daryl Kruse",
                "Wendell Keller",
                "Marcelino Campisi",
                "Antwan Hoppes",
                "Fritz Rosecrans",
                "Bertram Trojacek",
                "Dale Arizmendi",
                "Bryce Beeks",
                "Napoleon Acheson",
                "Bobbie Keever",
                "Ethan Masuda",
                "Geraldo Aguilera",
                "Harlan Lipinski",
                "Carlo Scruggs",
                "Ted Lamarr",
                "Burl Hamiter",
                "Jose Mckinnis",
                "Raymond Lyles",
                "Jeromy Reinoso",
                "Jasper Bowyer",
                "Doyle Stetson",
                "Keneth Lovick",
                "Gavin Hauptman",
                "Marquis Crosley",
                "Ignacio Hinckley",
                "Wally Kugel",
                "Mel Judah",
                "Alonzo Donald",
                "Clint Kaylor",
                "Casey Muldrew",
                "Lou Antone",
                "Elliott Ochs",
                "Whitney Mcchesney",
                "Fredrick Rudasill",
                "Cole Ochoa",
                "Chance Thrash",
                "Lloyd Jungers",
                "Arlen Mosqueda",
                "Duane Ensley",
                "Jacques Arruda",
                "Ed Harnish",
                "Malcolm Leonhardt"
            };

    public string[]
        humanFemaleNamesDatabase =
            new string[] {
                "Marylou Sybert",
                "Debbi Olivar",
                "Jacquie Fagundes",
                "Annelle Rencher",
                "Evelina Poulson",
                "Earlie Waldroup",
                "Tawna Gerlach",
                "Verna Alvino",
                "Song Arno",
                "Alta Sandman",
                "Jenee Frakes",
                "Eneida Watchman",
                "Delorse Belknap",
                "Odette Lam",
                "Nidia Marriott",
                "Angie Mcmullen",
                "Sofia Wiedeman",
                "Donita Coller",
                "Jenice Ables",
                "Melonie Lindow",
                "Emiko Bigger",
                "Maile Beckler",
                "Aleisha Caplinger",
                "Allena Ferriera",
                "Clara Yokota",
                "Clemencia Outler",
                "Shayla Troncoso",
                "Analisa Heyward",
                "Lisbeth Leong",
                "Merrie Otey",
                "Racheal Cressey",
                "Dayna Rankin",
                "Youlanda Gong",
                "Janie Leedom",
                "Venice Speier",
                "Aracelis Carman",
                "Tamatha Crenshaw",
                "Xuan Trousdale",
                "Jamee Wadley",
                "Joanne Wedge",
                "Evie Zahl",
                "Maira Vankirk",
                "Hortensia Ahearn",
                "Luvenia Couvillion",
                "Marguerite Barter",
                "Margarette Zahler",
                "Serina Job",
                "Bettie Meyers",
                "Judie Gendreau",
                "Suzy Mencer",
                "Candis Beighley",
                "Apryl Sarvis",
                "Marci Milledge",
                "Lekisha Delatte",
                "Willow Robichaud",
                "Noelle Reichel",
                "Tonita Schwandt",
                "Kimi Hagerman",
                "Chasity Houde",
                "Janell Mullan",
                "Fiona Kouba",
                "Avelina Damelio",
                "Pearle Smyers",
                "Merrilee Higginbottom",
                "Stacia Tjaden",
                "Vonda Keathley",
                "Vicki Salzano",
                "Diann Lesage",
                "Jeanmarie Huertas",
                "Corie Gorley",
                "Magdalen Bryan",
                "Linh Weisgerber",
                "Rossana Nevels",
                "Olive Pascoe",
                "Kizzy Tocco",
                "Wendi Wimbush",
                "Margot Keeter",
                "Wendy Judy",
                "Margit Troup",
                "Julietta Mahood",
                "Marx Northrup",
                "Veola Brookover",
                "Kiesha Alexandre",
                "Nelia Deibert",
                "Allena Domingue",
                "Nery Finan",
                "Marcene Selvy",
                "Berna Alexander",
                "Kittie Killebrew",
                "Allie Troutt",
                "Julianna Spiers",
                "Particia Dame",
                "Jacinda Turberville",
                "Deeanna Cerutti",
                "Tenesha Soo",
                "Ka Copp",
                "Eleanor Pickard",
                "Obdulia Daffron",
                "Corrine Thieme",
                "Melida Fletcher",
                "Candis Beighley",
                "Apryl Sarvis",
                "Marci Milledge",
                "Lekisha Delatte",
                "Willow Robichaud",
                "Noelle Reichel",
                "Tonita Schwandt",
                "Kimi Hagerman",
                "Chasity Houde",
                "Janell Mullan",
                "Fiona Kouba",
                "Avelina Damelio",
                "Pearle Smyers",
                "Merrilee Higginbottom",
                "Stacia Tjaden",
                "Vonda Keathley",
                "Vicki Salzano",
                "Diann Lesage",
                "Jeanmarie Huertas",
                "Corie Gorley",
                "Magdalen Bryan",
                "Linh Weisgerber",
                "Rossana Nevels",
                "Olive Pascoe",
                "Kizzy Tocco",
                "Wendi Wimbush",
                "Margot Keeter",
                "Wendy Judy",
                "Margit Troup",
                "Julietta Mahood",
                "Marx Northrup",
                "Veola Brookover",
                "Kiesha Alexandre",
                "Nelia Deibert",
                "Allena Domingue",
                "Nery Finan",
                "Marcene Selvy",
                "Berna Alexander",
                "Kittie Killebrew",
                "Allie Troutt",
                "Julianna Spiers",
                "Particia Dame",
                "Jacinda Turberville",
                "Deeanna Cerutti",
                "Tenesha Soo",
                "Ka Copp",
                "Eleanor Pickard",
                "Obdulia Daffron",
                "Corrine Thieme",
                "Melida Fletcher"
            };

    System.Random rand = new System.Random();

    public string[] getAllNames()
    {
        string[] allNames =
            new string[humanMalesNamesDatabase.Length +
            humanFemaleNamesDatabase.Length];
        humanMalesNamesDatabase.CopyTo(allNames, 0);
        humanFemaleNamesDatabase
            .CopyTo(allNames, humanMalesNamesDatabase.Length);

        return allNames;
    }

    public string generateName()
    {
        string[] allNames = getAllNames();
        int namesCount = allNames.Length;
        int randNumber = rand.Next(0, namesCount);

        return allNames[namesCount];
    }

    public double getRandom1ToZero()
    {
        return rand.NextDouble();
    }

    public Worker generateWorker()
    {
        Worker randWorker = new Worker(1);
        return randWorker;
    }

    public double generateMultiplier()
    {
        // You may add the complex logic so it is harder to get the two later
        float maxBaseMultiplier = 2;
        float minBaseMultiplier = 1;

        return Random.Range(minBaseMultiplier, maxBaseMultiplier);
    }

    public int randomAdditionalEmployeeCost()
    {
        return rand.Next(10);
    }
}
