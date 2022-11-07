using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

	//利用Enumerable.Range() 建立一個序列, 值介於[1, 10]請利用迴圈列出每一個項目值,確認無誤
	//用Enumerable.Range() 建立一個序列, 值介於[10, 15]請利用迴圈列出每一個項目值,確認無誤
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] result=Enumerable.Range(1,10 ).ToArray();
			foreach (var item in result)
			{
				Console.WriteLine(item);
			}

			int[] result2=Enumerable.Range(10,6).ToArray();
			foreach (var item in result2)
			{
				Console.WriteLine(item);
			}
		}
	}
}
