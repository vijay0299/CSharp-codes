// public class employees
// {   
//     private int empId;
//     private String empName;
//     private double empSalary;
//     private static int empCount;

//     public employees(int empId, String empName, double empSalary) {
//         this.empId = empId;
//         this.empName = empName;
//         this.empSalary = empSalary;
//         empCount++;
//     }

//     public void display() {
//         Console.WriteLine("{0},{1},{2}",this.empId, this.empName, this.empSalary);
//     }

//     // public static void count() {
//     //     Console.WriteLine("{0}",empCount);
//     // }

//         public static int count {
//             get {
//                 return empCount;
//             }
//     }

//     static void Main(string[] args)
//     {
//         employees e = new employees(1,"raj",3400000);
//         e.display();
    
//         employees e1 = new employees(2,"vj",3400000);
//         e1.display();

//         Console.WriteLine("emp count is {0}",employees.count);
//     }
// }