namespace TINHCHATLOP
{
    class KiemThu
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle(5,"xanh");
            Console.WriteLine(cir.ToString());
            Cylinder cy = new Cylinder(4,"do",3);
            Console.WriteLine(cy.ToString());
        }
    }
}