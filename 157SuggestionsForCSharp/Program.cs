using _157SuggestionsForCSharp.Suggesstions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _157SuggestionsForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(14);
            Console.Read();
        }
        static void Test(string MethodName)
        {

        }

        static void Test(int SuggestionNum)
        {
            var classname = "Suggesstion_" + SuggestionNum.ToString();
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            dynamic obj = assembly.CreateInstance("_157SuggestionsForCSharp.Suggesstions." + classname); // 创建类的实例，返回为 object 类型，需要强制类型转换
            try
            {
                obj.Test();
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
