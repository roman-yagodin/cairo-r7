//
//  Cairo.R7.Size.cs
//
//  Author:
//       Roman M. Yagodin <roman.yagodin@gmail.com>
//
//  Copyright (c) 2013 Roman M. Yagodin
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace Cairo.R7
{
	/// <summary>
	/// Size structure.
	/// </summary>
	public struct Size 
	{
		public int Width;
		public int Height;

		public Size (int w, int h)
		{
			this.Width = w;
			this.Height = h;

		}
	}

	/// <summary>
	/// Size structure with doubles.
	/// </summary>
	public struct SizeD
	{
		public double Width;
		public double Height;

		public SizeD (double w, double h)
		{
			this.Width = w;
			this.Height = h;

		}
	}
}

