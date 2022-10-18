// andrea burr
// 10-18-2022
// mini7 Mad Lib redo- github

Console.Clear();
bool playagain = true;

while (playagain){
    



Console.WriteLine("Lets make a mad lib!");
Console.WriteLine("enter your first Adjective");
string Adjective1 = Console.ReadLine();
Console.WriteLine("Great now enter your Second acjective");
string Adjective2 = Console.ReadLine();
Console.WriteLine("Great now enter a type of bird");
string Bird = Console.ReadLine();
Console.WriteLine("Great now enter a room in your house");
string Room = Console.ReadLine();
Console.WriteLine("Great now enter a past tense verb");
string verb1 = Console.ReadLine();
Console.WriteLine("Great now enter your second verb");
string verb2 = Console.ReadLine();
Console.WriteLine("Great now enter a family members name");
string Familymember = Console.ReadLine();
Console.WriteLine("Great now enter a noun");
string noun1 = Console.ReadLine();
Console.WriteLine(" great now enter a liquid");
string liquid1 = Console.ReadLine();
Console.WriteLine(" great now enter a verd ending in -ing");
string verb3 = Console.ReadLine();
Console.WriteLine(" great now enter abody part");
string bodyPart = Console.ReadLine();
Console.WriteLine(" great now enter a animal");
string animal1 = Console.ReadLine();


Console.WriteLine( "it was a " + Adjective1 + " cold November day. I woke up to the  " + Adjective2 +
 " smell of " + Bird +  " roasting in the "+ Room + " downstairs. i " + verb1 +
  " down the stairs to see if i could help " + verb2 + " the dinner. My mom told me to see if " + 
   Familymember + " needs a fresh " + noun1 + " so i carried a tray of glasses full of " +liquid1 + " into the "
   + verb3 + " room. When i got there, i couldnt belive my " + bodyPart + " there were " + animal1 + " everywhere! press any key to play again or enter no to quit" );
 string contPlay = Console.ReadLine();
 
 if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }
}

