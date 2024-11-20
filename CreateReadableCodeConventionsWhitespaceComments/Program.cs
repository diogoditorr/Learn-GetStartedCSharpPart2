/* 
    This code reverses a message, counts the number of times
    a particular character apperas, then prints the results
    to the console window.
*/

string message = "The quick brown fox jumps over the lazy dog.";

char[] messageLetters = message.ToCharArray();

Array.Reverse(messageLetters);

int count = 0;
foreach (char letter in messageLetters)
{
    if (letter == 'o')
    {
        count++;
    }
}

string newMessage = new String(messageLetters);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {count} times.");