# _ LINQ _ Language Integrated Query


<p>(Language Integrated Query) is uniform query syntax in C# and VB.Net to save and retrieve data from different sources. It is integrated in C# or VB,Â thereby eliminating the impedance mismatch between programming languages and databases, 
as well as providing a single querying interface for different types of data sources.</p>

<b> s => s.age > 18; </b>


class LINQQueryExpressions
{
    static void Main()
    {
        int[] scores = new int[] { 97, 92, 81, 60 };          // Specify the data source.

        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;                                   // Define the query expression.

        foreach (int i in scoreQuery)                       // Execute the query.
        {
            Console.Write(i + " ");
        }            
    }
}
// Output: 97 92 81