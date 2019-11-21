/*
 * Created by SharpDevelop.
 * User: Преподаватель
 * Date: 19.11.2019
 * Time: 15:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace testfigure
{
	class Program
	{
		public static void Main(string[] args)
		{
			test.figure f = new test.figure("1 1,4 5,7 1");
			Console.WriteLine( f.gets());
			Console.ReadKey(true);	
		}
	}
}
namespace test
{
	class figure
	{
		private double p;
		private double s;
		/// <summary>
		/// площадь круга
		/// </summary>
		/// <param name="r">радиус окружности</param>
		public figure(double r)
		{
			p=Math.PI*r*2;
			s=Math.PI*r*r;
		}
		/// <summary>
		/// Площадь прямоугольника
		/// </summary>
		/// <param name="a">сторона а</param>
		/// <param name="b">сторона б</param>
		public  figure(double a,double b)
		{
			p=2*(a+b);
			s=a*b;
		}
		/// <summary>
		/// площадь фигуры
		/// </summary>
		/// <param name="r">координаты точек</param>
		public   figure(string str)
		{
			string[] strOfPoints = str.Split(',');
			int size = strOfPoints.Length;
			double[][] points = new double[size+1][];
			for(int i=0;i<size;i++)
			{
				points[i]=new double[2];
				string[] pt=strOfPoints[i].Split(' ');
				points[i][0]=Convert.ToDouble(pt[0]);
				points[i][1]=Convert.ToDouble(pt[1]);
			}
			points[size]=new double[2];
			points[size][0]=points[0][0];
			points[size][1]=points[0][1];
			
			double sum=0;
			
			for(int i=0;i<size;i++)
			{
				sum+=(points[i][1]*points[i+1][0])-(points[i][0]*points[i+1][1]);
			}
			s=sum/2;
			
			
		}
		
		public double getp()
		{
			return p;
		}
		public double gets()
		{
			return s;
		}
	}
}