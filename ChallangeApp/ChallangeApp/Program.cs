var name = "Mateusz";
bool sex = true; //true = mężczyzna, false = kobieta
int age = 31;
string resultSex = string.Empty;

if (sex == true)
{
    resultSex = "mężczyzną.";
}
else if (sex == false)
{
    resultSex = "kobietą.";
}

if (sex == false && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == true && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Nazywasz się " + name + ". Masz " + age + " lat i jesteś " + resultSex);
}