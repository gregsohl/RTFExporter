# RTFExporter


A C# library to generate .RTF text files from any string object data, stylized and ready for any text processor. No fancy dependencies or restrictive licenses.


***Warning to Unity users: After the version 1.1.0 is necessary to use the .NET Framework 4.6 to the dll work properly.***


---


## Simple usage


IDisposable style:


```C#
using RTFExporter;

public class Example {

    public void IDisposableExample() {

        using (RTFDocument doc = new RTFDocument("example.rtf")) {
            var p = doc.AppendParagraph();

            p.style.alignment = Alignment.Center;
            p.style.indent = new Indent(1, 0, 0);
            p.style.spaceAfter = 400;

            var t = p.AppendText("Boy toy named Troy used to live in Detroit\n");
            t.content += "Big big big money, he was gettin' some coins";

            t.style.bold = true;
            t.style.color = new Color(255, 0, 0);
            t.style.fontFamily = "Courier";
        }

    }

}
```


String style:


```C#
using RTFExporter;

public class Example {

    public void StringExample() {

        RTFDocument doc = new RTFDocument();
        RTFParagraph p = new RTFParagraph(doc);

        RTFText t1 = new RTFText(p, "My anaconda don't, my anaconda don't\n");
        t1.SetStyle(new Color(255, 0, 0), 18, "Helv");

        RTFText t2 = new RTFText(p, "My anaconda don't want none unless you got buns, hun");
        t2.style = t1.style;

        string output = RTFParser.ToString(doc);

    }

}
```


---


## Features


- Document
    - Set page size
    - Set orientation
    - Set margin
    - Set units (inch, mm, cm)


- Paragraph style
    - Set indent
    - Set text alignment
    - Set spacing


- Text style
    - Set color
    - Set font family
    - Set font size
    - Set style: bold, italic, small caps, all caps, strike through and outline
    - Set 8 different types of underline


---


## Missing


- Support to non-latin characters
- Use stylesheets
- Lists
- And a lot more of RTF stuff


---


## License  (WTFPL-2.0)


<a href="http://www.wtfpl.net/"><img src="http://www.wtfpl.net/wp-content/uploads/2012/12/wtfpl-badge-4.png" width="80" height="15" alt="WTFPL" /></a>
