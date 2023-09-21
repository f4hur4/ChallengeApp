
using System.ComponentModel.Design;

string name = ("Ewa");
string sex = ("Kobieta");
var age = 29;
if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("KObieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (name != "Ewa" && age <= 18)
{
    Console.WriteLine("nie pełnoletni mężczyzna");
}
else
{
    Console.WriteLine("pelnoletni mężczyzna");
}