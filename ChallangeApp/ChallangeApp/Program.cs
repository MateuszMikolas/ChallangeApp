long number = 112222233399900;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();
int[] numberOfDigits = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
char[] digitsInChar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

for (int a = 0; a < letters.Length; a++)
{
    for (int b = 0; b <= 9; b++)
    {
        if (letters[a] == digitsInChar[b])
        {
            numberOfDigits[b]++;
        }
    }
}

for (int c = 0; c < numberOfDigits.Length; c++)
{
        Console.WriteLine(digitsInChar[c] + " => " + numberOfDigits[c] + " szt.");
}