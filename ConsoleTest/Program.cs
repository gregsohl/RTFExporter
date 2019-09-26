using System;
using System.Diagnostics;
using System.IO;

using RTFExporter;

namespace ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			RTFTextStyle normalStyle = new RTFTextStyle(
				false,
				false,
				false,
				false,
				false,
				false,
				10,
				"Arial",
				RtfColor.Black,
				Underline.None);

			RTFTextStyle fieldNameStyle = new RTFTextStyle(
				false,
				true,
				false,
				false,
				false,
				false,
				10,
				"Arial",
				RtfColor.Red,
				Underline.None);

			RTFTextStyle valueStyle = new RTFTextStyle(
				true,
				false,
				false,
				false,
				false,
				false,
				10,
				"Arial",
				RtfColor.Blue,
				Underline.None);

			var fileName = @"d:\temp\test.rtf";

			using(FileStream fs = File.Create(fileName))
			using (RTFDocument rtf = new RTFDocument(fs))
			{
				var paragraph = rtf.AppendParagraph();

				var rtfText = new RTFText(paragraph, "Field ");
				rtfText.SetStyle(normalStyle);

				rtfText = new RTFText(paragraph, "Due Date");
				rtfText.SetStyle(fieldNameStyle);

				rtfText = new RTFText(paragraph, " changed to ");
				rtfText.SetStyle(normalStyle);

				rtfText = new RTFText(paragraph, "03/01, 04/01");
				rtfText.SetStyle(valueStyle);

				// string output = RTFParser.ToString(rtf);
			}

			// Launch the file in default RTF handler
			ProcessStartInfo psi = new ProcessStartInfo(fileName);
			psi.UseShellExecute = true;
			Process.Start(psi);
		}
	}
}
