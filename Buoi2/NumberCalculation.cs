
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
        /// <summary>
        ///  (a,b) => resutlt= a+b;
        /// </summary>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
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
