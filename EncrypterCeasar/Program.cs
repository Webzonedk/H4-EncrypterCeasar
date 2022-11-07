Console.WriteLine("Please type Your secret word:");
string? secretWord= Console.ReadLine();
Console.WriteLine("Please select your secret number:");
string? secretNumber = Console.ReadLine();
Console.WriteLine("We have now encrypted your message");
Console.WriteLine("Youe encrypted message is:");
Console.WriteLine(EncrypterCeasar.Encrypter.Encrypt(secretWord,secretNumber));
Console.ReadKey();