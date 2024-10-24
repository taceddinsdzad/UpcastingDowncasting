namespace UpcastingDowncasting
{
    internal abstract class Fruit
    {
        public double Price { get; set; }
        public string Sort { get; set; }
        public virtual void Taste()
        {
            Console.WriteLine("meyve sirndir");
        }
    }
}
