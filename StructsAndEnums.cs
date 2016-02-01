using System;
using System.Runtime.InteropServices;

namespace FloodFill
{
	[StructLayout (LayoutKind.Sequential)]
	public struct PointNode
	{
		public int nextNodeOffset;

		public int point;
	}
}

