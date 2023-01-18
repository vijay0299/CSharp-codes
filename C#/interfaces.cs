public class interfaces
{
    interface Irectangle {
        void getArea(double l, double b);
        // void getPerimeter(double l, double b);
    }

    interface Isquare {
        void getArea(double a);
        // void getPerimeter(double a);
    }

    interface Itriangle {
        void getArea(double b, double h);
    }
    class shape : Irectangle, Isquare, Itriangle {
        void Irectangle.getArea(double l, double b) {
            Console.WriteLine("rect Area is {0}", (l*b));
        }

        void Isquare.getArea(double a)
        {
            Console.WriteLine("sq Area is {0}", (a*a));
        }

        void Itriangle.getArea(double b, double h)
        {
            Console.WriteLine("tri sq Area is {0}", (0.5 * b * h));
        }

        // void getPerimeter(double l, double b)
        // {
        //     Console.WriteLine("Perimeter is {0}", (2*(l+b)));
        // }

        // public void getPerimeter(double a)
        // {
        //     Console.WriteLine("sq Perimeter is {0}", (4*a));
        // }
    }
    static void Main(string[] args)
    {
        Irectangle rect = new shape();
        rect.getArea(3,3);

        Itriangle tri = new shape();
        tri.getArea(1,2);

        Isquare sq = new shape();
        sq.getArea(2);
    }
}