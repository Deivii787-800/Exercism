public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimeter)
    {
        int startAt = str.IndexOf(delimeter) + delimeter.Length;
        return str.Substring(startAt);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string startDelimeter, string endDelimeter)
    {
        int startAt = str.IndexOf(startDelimeter) + startDelimeter.Length;
        int endAt = str.IndexOf(endDelimeter);
        return str.Substring(startAt, endAt - startAt);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ").Trim();
    

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
    
}