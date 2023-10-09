namespace PatternsExample.Base;

public abstract class Document : IPrintable
{
    protected readonly List<Page> Pages = new List<Page>();

    public IEnumerable<Page> AllPages => Pages;

    void IPrintable.Print()
    {
        //Pages.Clear();
        if (!Pages.Any())
        {
            RenderDocument();
        }
        // print document
    }
    protected abstract void RenderDocument();
}