
namespace Buoi2
{
    public class NumberCalculation
    {
        public string Name;
        public int Add(int a,int b=20)
        {
           int result= a + b;
           return result;
        }
        public int Subtract(int c, int d)
        {
            return c - d;
        }
      
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
        
    }
}
