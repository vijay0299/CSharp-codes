// public class inheritance
// {
//     public class A {

//         private int n1, n2;

//         public A() {

//         }
//         public A(int n1, int n2) {
//             this.n1=n1;
//             this.n2=n2;
//         }
//         // public virtual void add(int a , int b) {
//         //     Console.WriteLine("sum is {0}", a+b);
//         // }

//          public virtual void add() {
//             Console.WriteLine("sum is {0}", n1+n2);
//         }
//     }

//     public class B:A {

//         private int n1, n2;
//         public B(int n1, int n2):base(n1, n2) {
//             this.n1=n1;
//             this.n2=n2;
//         }
//         //METHOD HIDING EXAMPLE
//         //WE WILL ADD "NEW" KEYWORD
//         // public new void add(int a, int b) {                         
//         //     Console.WriteLine("sum of 2 no's is {0}", a+b);
//         // }


//         //METHOD OVERRIDING EXAMPLE 
//         //WE WILL ADD "VIRTUAL" KEYWORD IN BASE CLASS AND "OVERRDE" KEYWORD IN DERIVED CLASS 
//         // public override void add(int a, int b) {                         
//         //     Console.WriteLine("sum of 2 no's is {0}", a+b);
//         // }


//         public void diff() {
//             Console.WriteLine("diff is {0}", n1-n2);
//         }
//     }

//     static void Main(string[] args)
//     {
//         // B b = new B();
//         // b.add(1,2);     //invokes derived class

//         // A a = new B();
//         // a.add(5,8);     //invokes base class
//         B b = new B(12,4);
//         b.add();
//         b.diff();
//     }
// }