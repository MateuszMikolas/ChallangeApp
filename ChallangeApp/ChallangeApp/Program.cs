using ChallangeApp;

Employee user1 = new Employee("Mariusz", "Mały", 30);
Employee user2 = new Employee("Adam", "Średni", 40);
Employee user3 = new Employee("Kali", "Duży", 50);

for (int a = 0; a < 5; a++)
{
    Random b = new Random();
    user1.AddScore(b.Next(1, 11));
}

for (int a = 0; a < 5; a++)
{
    Random b = new Random();
    user2.AddScore(b.Next(1, 11));
}

for (int a = 0; a < 5; a++)
{
    Random b = new Random();
    user3.AddScore(b.Next(1, 11));
}

