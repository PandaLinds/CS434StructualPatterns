using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTest : MonoBehaviour
{
    public void ShouldSupportCondiments()
{
    var beverages = new List<ICoffee>
    {
        new ChocolateDecorator(new Filtered()),
        new ChocolateDecorator(new MilkDecorator(new Espresso()))
    };
 
    var filteredWithChocolate = beverages[0]; 
    if("Filtered with care, Chocolate" != filteredWithChocolate.GetDescription())
    {
        return;
    }
    if((1.99 + 0.29) != filteredWithChocolate.GetCost())
    {
        return;
    }
    Debug.Log("Filtered with coffee discription and cost: "+filteredWithChocolate.GetDescription()+" "+filteredWithChocolate.GetCost());
 
    var espressoWithMilkAndChocolate = beverages[1];
    if("Espresso made with care, Milk, Chocolate" != espressoWithMilkAndChocolate.GetDescription())
    {
        return;
    }
    if((2.99 + 0.19 + 0.29) != espressoWithMilkAndChocolate.GetCost())
    {
        return;
    }
    Debug.Log("Milk and Chocolate coffee discription and cost: "+espressoWithMilkAndChocolate+" "+espressoWithMilkAndChocolate.GetCost());
    Debug.Log("Espressos made!");
}

    // Start is called before the first frame update
    void Start()
    {
        ShouldSupportCondiments();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
