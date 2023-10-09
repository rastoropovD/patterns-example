// See https://aka.ms/new-console-template for more information

using PatternsExample.Base;
using PatternsExample.BusinessLogic.Documents;

Console.WriteLine("Hello, World!");

Document[] documents = new Document[2];

documents[0] = new CvDocument();
documents[1] = new ReportDocument();

foreach (Document doc in documents)
{
  //  doc.RenderDocument();
    ((IPrintable)doc).Print();
    //IPrintable printable = doc;
    //printable.Print();
}

Console.Read();