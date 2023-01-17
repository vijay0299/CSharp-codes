public class gradeSystem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter your score: ");
        int score  = Convert.ToInt32(Console.ReadLine());

        if(score<0 || score >100) {
            Console.WriteLine("invalid score");
        } else if(score>=0 && score<50) {
            Console.WriteLine("Fail");
        } else if(score>=50 && score<60){
            Console.WriteLine("D grade");
        } else if(score>=60 && score<70){
            Console.WriteLine("C grade");
        } else if(score>=70 && score<80){
            Console.WriteLine("B grade");
        } else if(score>=80 && score<90){
            Console.WriteLine("A grade");
        } else if(score>=90 && score<=100){
            Console.WriteLine("S grade");
        }
    }
}