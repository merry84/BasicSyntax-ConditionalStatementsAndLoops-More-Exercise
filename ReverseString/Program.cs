//Create a program which reverses a string and prints it on the console.

string word = Console.ReadLine();
string reverse = "";
for (int i = word.Length - 1; i >= 0; i--)
{
    reverse += word[i];
}
Console.WriteLine(reverse);
