namespace PatternsExample.Builder;

public sealed class ProductB : Builder
{
    private readonly Product _product = new Product();
    
    public override void BuildPartA()
    {
        _product.Add("Part 1 for ProductB");
    }

    public override void BuildPartB()
    {
        _product.Add("Part 2 for ProductB");
    }

    public override Product GetResult()
    {
        return _product;
    }
}