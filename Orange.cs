namespace UpcastingDowncasting
{
    internal class Orange : Fruit
    {
        public int VitaminC { get; set; }
        public override void Taste()
        {
            Console.WriteLine("portağal turş olur");
        }
    }
}
