using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_1
{
	public class DemoPoint : IDemo, IComparable<DemoPoint>
	{
		protected int x;
		protected int y;
		public DemoPoint(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public void Show()
		{
			Console.WriteLine("точка на площині: ({0}, {1})", x, y);
		}

		public double Dlina()
		{
			return Math.Sqrt(x * x + y * y);
		}

		public int X => x;
		public int Y => y;

		public int this[int i]
		{
			get
			{
				if (i == 0) return x;
				else if (i == 1) return y;
				else throw new Exception("неприпустиме значення індексу");
			}
			set
			{
				if (i == 0) x = value;
				else if (i == 1) y = value;
				else throw new Exception("неприпустиме значення індексу");
			}
		}

		public int CompareTo(DemoPoint somePoint)
		{
			if (this.Dlina() == somePoint.Dlina()) return 0;
			else if (this.Dlina() > somePoint.Dlina()) return 1;
			else return -1;
		}
	}
}