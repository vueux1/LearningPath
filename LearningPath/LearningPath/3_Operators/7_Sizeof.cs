namespace LearningPath.Operators;

public class Sizeof {
    /*
     * Verilen türün bellekte kaç byte yer kapladığını integer olarak gösterir. 
     * Shows how many bytes the given type occupies in memory as an integer.
     */

    public void ExampleSizeOfOperator()
    {
        Console.WriteLine(sizeof(int)); // Output: 4
        Console.WriteLine(sizeof(double)); // Output: 8
        Console.WriteLine(sizeof(string)); // Output: 24 (string tipindeki her karakter 2 byte) / (each character in the string type is 2 bytes)
        Console.WriteLine(sizeof(char)); // Output: 2
    }
}
