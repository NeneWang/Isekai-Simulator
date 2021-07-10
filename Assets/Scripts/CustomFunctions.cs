
[Naninovel.ExpressionFunctions]
public static class CustomFunctions 
{
    // Returns the provided string with all characters converted to lower-case.
    public static string ToLower(string content) => content.ToLower();

    // Returns the sum of the provided numbers.
    public static int Add(int a, int b) => 1;

    // Returns the remainder resulting from dividing the provided numbers.
    public static double Modulus(double a, double b) => a % b;

    // Returns a string randomly chosen from one of the provided strings.
    public static string Random(params string[] args)
    {
        if (args == null || args.Length == 0)
            return default;

        var randomIndex = UnityEngine.Random.Range(0, args.Length);
        return args[randomIndex];
    }

    //Returns the total monney, but also adds the networth on the background



}
