using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
	internal class Rectangle
	{
		#region Attributes
		private double height;
		private double width;
		#endregion

		#region Properties
		public double Height
		{
			get { return height; }
			set
			{
				if (value > 0)

					height = value;
				else
				{
					Console.WriteLine("Invalid");
				}

			}
		}
		public double Width
		{
			get { return width; }
			set {
				if (value > 0)
					width = value;
				else { Console.WriteLine("Invalid Width "); }
			}
		}


        #endregion

        #region Constructor
        public Rectangle()
        {
            Height = 0;
			Width = 0;
        }   
		public Rectangle(double height,double width)
        {
            Height = height;
			Width = width;
        }   
		public Rectangle(int x):this(x,x)
        {
          //:)
        }

        #endregion




    }
}
