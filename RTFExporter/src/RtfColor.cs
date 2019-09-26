namespace RTFExporter
{
	/// <summary>
	/// A class to manage RTF colors as rgb values from 0 to 255
	/// </summary>
	public class RtfColor
	{
		public byte r;
		public byte g;
		public byte b;
		public int index;
		public static readonly RtfColor Black = new RtfColor(0, 0, 0);
		public static readonly RtfColor White = new RtfColor(255, 255, 255);
		public static readonly RtfColor Red = new RtfColor(255, 0, 0);
		public static readonly RtfColor Green = new RtfColor(0, 255, 0);
		public static readonly RtfColor Blue = new RtfColor(0, 0, 255);
		public static readonly RtfColor Yellow = new RtfColor(255, 255, 0);
		public static readonly RtfColor Purple = new RtfColor(255, 0, 255);
		public static readonly RtfColor Cyan = new RtfColor(0, 255, 255);

		/// <summary>
		/// RtfColor constructor
		/// </summary>
		/// <param name="r">Red</param>
		/// <param name="g">Green</param>
		/// <param name="b">Blue</param>
		public RtfColor(
			byte r,
			byte g,
			byte b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RtfColor"/> class.
		/// </summary>
		/// <param name="color">The color.</param>
		public RtfColor(System.Drawing.Color color)
		{
			r = color.R;
			g = color.G;
			b = color.B;
		}
	}
}
