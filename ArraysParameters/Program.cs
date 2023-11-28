internal class Program
{
    private static void Main(string[] args)
    {

        int[] studentsGrade = { 9, 8, 8, 7, 9, 10, 7};
        double averageResult = GetAverage(studentsGrade);

        foreach( int grade in studentsGrade )
        {
            Console.WriteLine("{0}", grade);
        }

        Console.WriteLine("The average is {0}", averageResult);
        Console.ReadKey();  




    }

    static double GetAverage(int[] gradesArray)
    {
        int size = gradesArray.Length;  
        double sum = 0;
        double average;

        for(int i = 0; i < size; i++)
        {
            sum += gradesArray[i];

        }


        average =(double) sum / size;
        return average;


    }
}