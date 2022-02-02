string first = "The cars we sell are";
string second = "BMW, Lexus, Subaru, Mercedes, and Tesla";

string concatenatedResult = first + " " + second;

Console.WriteLine(concatenatedResult);

string firstName = "Lucas";

string lastName = "Coxe";

string compositeResult = string.Format("His name is {0} {1}", firstName, lastName);

Console.WriteLine(compositeResult);

string interpolationResult = $"His name is still {firstName} {lastName}! ";
Console.WriteLine(interpolationResult);

