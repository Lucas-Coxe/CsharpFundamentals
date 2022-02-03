bool isSnowing = true;
bool isGoingOutside = true;

if(isSnowing)
{
    Console.Writeline("It is snowing outside");  
}
  
if(!isSnowing || isGoingOutside)
{
    Console.Writeline("Better wear some snow boots !!");
}

if(isSnowing ^ isGoingOutside)
{
    Console.Writeline("I will only go outside once the snow stops");
}
if(isSnowing){
    Console.WriteLine("There is no need to shovel snow");
}

else{
    Console.WriteLine("I guess I need to shovel the driveway ");
}

if(isSnowing){
    Console.Writeline("I guess I have to go clear off the wife's car");
}

else if(!isSnowing){
    Console.Writeline("I don't have to clear off cars! ");
}

else{
    Console.Writeline("I don't even know what we are talking about");
    }