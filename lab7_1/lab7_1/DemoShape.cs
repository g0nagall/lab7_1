using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_1
{
	class DemoShape : DemoPoint, IDemo
	{
		protected int z;
		public DemoShape(int x, int y, int z) : base(x, y)
		{
			this.z = z;
		}

		public new void Show()
		{
			Console.WriteLine("точка в пространстве: ({0}, {1}, {2})", x, y, z);

		}

		public new double Dlina()
		{
			return Math.Sqrt(x * x + y * y + z * z);
		}

		public new int this[int i]
		{
			get
			{
				if (i == 0) return x;
				else if (i == 1) return y;
				else if (i == 2) return z;
				else throw new Exception("неприпустиме значення індексу");
			}
			set
			{
				if (i == 0) x = value;
				else if (i == 1) y = value;
				else if (i == 2) z = value;
				else throw new Exception("неприпустиме значення індексу");
			}
		}
	}
}