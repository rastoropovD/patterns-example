namespace PatternsExample.Builder;

public sealed class ProductA : Builder
{
    private readonly Product _product = new Product();
    
    public override void BuildPartA()
    {
        _product.Add("Part 1 for ProductA");
    }

    public override void BuildPartB()
    {
        _product.Add("Part 2 for ProductA");
    }

    public override Product GetResult()
    {
        return _product;
    }
}