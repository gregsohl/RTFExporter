using System.Diagnostics;

namespace RTFExporter
{
	public class RTFHyperlink : RTFText
	{
		private readonly string m_Hyperlink;

		public RTFHyperlink(
			RTFParagraph paragraph,
			string content,
			string hyperlink)
			: base(paragraph, content)
		{
			m_Hyperlink = hyperlink;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RTFHyperlink"/> class.
		/// </summary>
		/// <param name="paragraph">The paragraph.</param>
		/// <param name="content">The content.</param>
		/// <param name="hyperlink">The hyperlink.</param>
		/// <param name="sourceStyle">The source style to base the hyperlink style from. Adds blue and underline to the source style.</param>
		public RTFHyperlink(
			RTFParagraph paragraph,
			string content,
			string hyperlink,
			RTFTextStyle sourceStyle)
			: base(paragraph, content, sourceStyle)
		{
			style = new RTFTextStyle(sourceStyle);
			style.underline = Underline.Basic;
			style.color = RtfColor.Blue;

			m_Hyperlink = hyperlink;
		}

		public string Hyperlink
		{
			[DebuggerStepThrough]
			get { return m_Hyperlink; }
		}
	}
}
