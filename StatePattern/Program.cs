namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            TV tv = new TV(new TVOffState());
            Console.WriteLine($"Current TV State : {tv.CurrentState.GetType().Name}\n");
            tv.TurnONTV();
            tv.TurnOffTV();
            
            Console.WriteLine($"\nCurrent TV State : {tv.CurrentState.GetType().Name}\n");
            tv.TurnOffTV();
            tv.TurnONTV();
      
            Console.WriteLine($"\nCurrent TV State : {tv.CurrentState.GetType().Name}");
            Console.Read();
        }
    }
}