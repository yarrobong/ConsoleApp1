int newInt = 10;
float newFloat = (float) 8.4;
string newStr = "true";

float bigInt = (float)(newInt * 3.5);

newFloat = newFloat - 1;

Console.WriteLine(newInt / newFloat);
Console.WriteLine(bigInt / newFloat);

newStr = "NoNo"  + "YesYesYes";

Console.WriteLine("newInt: " + newInt);
Console.WriteLine("newFloat: " + newFloat);
Console.WriteLine("newStr: " + newStr);

