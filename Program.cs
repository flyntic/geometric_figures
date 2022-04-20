using PrZadanie;


N_angle[] n_angles = new N_angle[]
{
    new Triangle()
    {
        Points = new Point[] {new Point {X = 2, Y = 0}, new Point {X = 3, Y = 0}, new Point {X = 4, Y = 10}}
    },
    new FourAngle()
    {
        Points = new Point[]
            {new Point {X = 2, Y = 0}, new Point {X = 3, Y = 0}, new Point {X = 4, Y = 10}, new Point {X = 4, Y = 13}}

    },
    new FourAngle()
    {
        Points = new Point[]
            {new Point {X = 2, Y = 0}, new Point {X = 3, Y = 0}, new Point {X = 4, Y = 10}, new Point {X = 4, Y = 13}}

    },
    new Triangle()
    {
        Points = new Point[] {new Point {X = 2, Y = 0}, new Point {X = 3, Y = 0}, new Point {X = 4, Y = 10}}

    }
};


foreach (N_angle n in n_angles)
{
    //Square t = n;
    if (n as FourAngle != null)
    {
        FourAngle t = FourAngle(n);
        Square z = t;
         if (z.isSquare()) Console.WriteLine(z);
    }
}
   
   
   
   