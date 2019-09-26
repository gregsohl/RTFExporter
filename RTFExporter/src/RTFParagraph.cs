using System.Collections.Generic;

namespace RTFExporter
{
	/// <summary>
	/// The RTF paragraph class, every class need a document to append
	/// </summary>
	public class RTFParagraph
	{
		#region Public Constructors

		/// <summary>
		/// The RTF paragraph constructor
		/// <seealso cref="RTFExporter.RTFDocument">
		/// </summary>
		/// <param name="document">The RTF document to append the paragraph</param>
		public RTFParagraph(
			RTFDocument document)
		{
			style = new RTFParagraphStyle(document);
			document.paragraphs.Add(this);
		}

		#endregion Public Constructors

		#region Public Fields

		public RTFParagraphStyle style;
		public List<RTFText> text = new List<RTFText>();

		#endregion Public Fields

		#region Public Methods

		/// <summary>
		/// The method to add a text to a paragraph
		/// <seealso cref="RTFExporter.RTFText">
		/// </summary>
		/// <param name="content">The text content</param>
		/// <returns>Return the text instantiated with the content</returns>
		public RTFText AppendText(
			string content)
		{
			RTFText appendedText = new RTFText(this, content);
			return appendedText;
		}

		/// <summary>
		/// The method to add a text to a paragraph
		/// <seealso cref="RTFExporter.RTFText">
		/// <seealso cref="RTFExporter.RTFTextStyle">
		/// </summary>
		/// <param name="content">The text content</param>
		/// <param name="textStyle">The text styler</param>
		/// <returns>Return the text instantiated with the content and the style</returns>
		public RTFText AppendText(
			string content,
			RTFTextStyle textStyle)
		{
			RTFText text = new RTFText(this, content, textStyle);
			return text;
		}

		#endregion Public Methods
	}
}
