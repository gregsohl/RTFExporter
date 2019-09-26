namespace RTFExporter
{
	/// <summary>
	/// Underline types
	/// </summary>
	public enum Underline
	{
		None,
		Basic,
		Double,
		Thick,
		WordsOnly,
		Wave,
		Dotted,
		Dash,
		DotDash
	}

	/// <summary>
	/// A group of text styling configuration
	/// </summary>
	public class RTFTextStyle
	{
		#region Public Constructors

		/// <summary>
		/// The simple style constructor
		/// <seealso cref="RtfColor"/>
		/// </summary>
		/// <param name="italic">Is italic?</param>
		/// <param name="bold">Is bold?</param>
		/// <param name="fontSize">Font size in pt</param>
		/// <param name="fontFamily">A valid font family, will use Calibri if doesn't exist</param>
		/// <param name="color">A rgb color to the text</param>
		public RTFTextStyle(
			bool italic,
			bool bold,
			int fontSize,
			string fontFamily,
			RtfColor color)
		{
			this.italic = italic;
			this.bold = bold;
			this.fontSize = fontSize;
			this.fontFamily = fontFamily;
			this.color = color;
		}

		/// <summary>
		/// The style constructor
		/// <seealso cref="RtfColor"/>
		/// <seealso cref="RTFExporter.Underline"/>
		/// </summary>
		/// <param name="italic">Is italic?</param>
		/// <param name="bold">Is bold?</param>
		/// <param name="smallCaps">Use all small caps?</param>
		/// <param name="strikeThrough">Use strike through?</param>
		/// <param name="allCaps">Use all caps?</param>
		/// <param name="outline">Has outline?</param>
		/// <param name="fontSize">Font size in pt</param>
		/// <param name="fontFamily">A valid font family, will use Calibri if doesn't exist</param>
		/// <param name="color">A rgb color to the text</param>
		/// <param name="underline">The underline type</param>
		public RTFTextStyle(
			bool italic,
			bool bold,
			bool smallCaps,
			bool strikeThrough,
			bool allCaps,
			bool outline,
			int fontSize,
			string fontFamily,
			RtfColor color,
			Underline underline)
		{
			this.italic = italic;
			this.bold = bold;
			this.smallCaps = smallCaps;
			this.strikeThrough = strikeThrough;
			this.allCaps = allCaps;
			this.outline = outline;
			this.fontSize = fontSize;
			this.fontFamily = fontFamily;
			this.color = color;
			this.underline = underline;
		}

		public RTFTextStyle(
			RTFTextStyle sourceStyle)
		{
			italic = sourceStyle.italic;
			bold = sourceStyle.bold;
			smallCaps = sourceStyle.smallCaps;
			strikeThrough = sourceStyle.strikeThrough;
			allCaps = sourceStyle.allCaps;
			outline = sourceStyle.outline;
			fontSize = sourceStyle.fontSize;
			fontFamily = sourceStyle.fontFamily;
			color = sourceStyle.color;
			underline = sourceStyle.underline;
		}

		#endregion Public Constructors

		#region Public Fields

		public bool allCaps;
		public bool bold;
		public RtfColor color;
		public string fontFamily;
		public int fontSize;
		public bool italic;
		public bool outline;
		public bool smallCaps;
		public bool strikeThrough;
		public Underline underline;

		#endregion Public Fields
	}
}
