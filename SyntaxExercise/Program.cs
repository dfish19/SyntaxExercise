int answer = 4;
string response;
if (answer < 9)
{
    response = answer + " is less than nine";
}
else
{
    response = answer + " is greater than or equal to nine";
}
Console.WriteLine(response);




var answer1 = 4;
var response1 = answer1 < 9 ? $"{answer1} is less than nine" : $"{answer1} greater than or equal to nine";
Console.WriteLine(response1);
