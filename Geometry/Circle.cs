﻿using System;

namespace Geometry
{
	public class Circle : IFigure
	{
		public const double MinRadius = 1e-6;

		/// <exception cref="ArgumentException"></exception>
		public Circle(double radius)
		{
			if (radius - MinRadius < Constants.CalculationAccuracy)
				throw new ArgumentException($"{nameof(radius)}, не может использоваться как радиус");
			Radius = radius;
		}

		public double Radius { get; }

		public double GetSquare()
		{
			return Math.PI * Math.Pow(Radius, 2d);
		}
	}
}