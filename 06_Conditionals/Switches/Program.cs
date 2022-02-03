System.Console.WriteLine("Please give us your name !");
string name = System.Console.ReadLine();
switch(name)
{
    case "Lucas":
    System.Console.WriteLine("Nice to meet you " + name);
    break;
    default:
    break;
}

System.Console.WriteLine("How are you feeling today on a scale of 1-5 ");
string feelingRating = System.Console.ReadLine();

switch(feelingRating){

    case "5":
    System.Console.WriteLine("That is great to hear that! ");
    break;
    
    case "4":
    System.Console.WriteLine(" That's good!");
    break;

    case "3":
    System.Console.WriteLine("Is everything okay? ");
    break;

    case "2":
    System.Console.WriteLine("Sorry to hear that ");
    break;

    case "1":
    System.Console.WriteLine("It will get better");
    break;
}


