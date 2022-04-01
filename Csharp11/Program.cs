

//Newlines in interpolated strings
var str = $"{Subscriber
    .GetSubscribers("name")
    .FirstOrDefault()}";

Console.WriteLine(str);

// List Patterns
var list = new[] { "1", "2", "3", "4", "5", "6" };

Console.WriteLine(list is ["1", .., "6"]);

if (list is ["1", .. var rest, "6"])
{
    foreach (var item in rest)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

// Bang Bang
try
{
    Subscriber.GetSubscribers(null);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();

class Subscriber
{
    public static List<string> GetSubscribers(string userName)
    {
        if (userName is null)
        {
            throw new ArgumentNullException(nameof(userName));
        }
        return new List<string>();
    }
}