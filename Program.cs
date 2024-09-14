using System.Security.Cryptography;
DisplayMenu();
string userChoice = GetMenuChoice(); 
while (userChoice != "2"){
    string enjoymentLevel = GetEnjoymentLevel(); 
    string stadium = GetStadiumRecommendation(enjoymentLevel); 
    string game = GetGameRecommendation(stadium); 
    DisplayStadiumDetails(enjoymentLevel, stadium, game);
    DisplayMenu(); 
    userChoice = GetMenuChoice(); 
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("1. Find a game \n2. Exit");
}

static string GetMenuChoice(){
    System.Console.WriteLine("Enter your choice:");
    return Console.ReadLine(); 
}

static string GetEnjoymentLevel(){
    System.Console.WriteLine("From boring to epic, what is your preferred level of enjoyment?");
    return Console.ReadLine().ToLower(); 
}

static string GetStadiumRecommendation(string enjoymentLevel){
    switch(enjoymentLevel){
        case "boring":
            return "Neyland Stadium";
        case "average":
            return "Jordan-Hare Stadium";
        case "fun":
            return "Tiger Stadium";
        case "epic":
            return "Saban Field at Bryant-Denny Stadium";
        default:
            return "Invalid enjoyment level choice!";
            Pause();
    } 
}
static string GetGameRecommendation(string stadium){
    if (stadium.ToLower() == "neyland stadium"){
        return "vs Kent State";
    }
    else if (stadium.ToLower() == "jordan-hare stadium"){
        return "vs Kentucky";
    }
    else if (stadium.ToLower() == "tiger stadium"){
        return "vs Alabama";
    }
    else if (stadium.ToLower() == "saban field at bryant-denny stadium"){
        return "vs Auburn"; 
    }
    else {
        System.Console.WriteLine("Invalid stadium!");
        return ""; 
    }
}
static void DisplayStadiumDetails(string enjoymentLevel, string stadium, string game){
    Console.Clear();
    if (stadium == "Invalid enjoyment level choice!" || game == "Invalid stadium!"){
        System.Console.WriteLine("Your enjoyment level doesn't translate to a game to go to! Try again.");
        Pause();
        
    }
    System.Console.WriteLine($"Based on your enjoyment level: {enjoymentLevel}, you should attend the game at {stadium} {game}!");
    Pause();
}

static void Pause() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}