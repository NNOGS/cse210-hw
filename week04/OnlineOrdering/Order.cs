using System;
using System.Numerics;
using System.Reflection.Emit;

public class Order
{
    //Private member variables
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Add product to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total cost
    public double GetTotalCost()
    {
        double total = 0;
    

    //Add cost of all products
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        //Add shipping cost
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }   
    
    // Generating Packaging label
    public string GetPackagingLabel()
    {
        string label = "Packaging Label:\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} ({product.GetProductId()})\n";
        }
        return label;
    }

    // Generating shipping Label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
    
}