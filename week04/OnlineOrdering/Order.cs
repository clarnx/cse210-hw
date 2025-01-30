class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        List<string> labels = new List<string>();
        foreach (var product in products)
        {
            labels.Add(product.GetPackingLabel());
        }
        return string.Join("\n", labels);
    }

    public string GetShippingLabel()
    {
        return customer.GetShippingLabel();
    }
}