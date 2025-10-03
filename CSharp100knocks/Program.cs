var dict = new Dictionary<string, int>{{"a", 1}};
if (dict.TryGetValue("a", out int value))
    Console.WriteLine(value);