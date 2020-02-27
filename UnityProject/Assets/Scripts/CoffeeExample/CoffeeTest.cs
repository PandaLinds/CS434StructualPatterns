using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTest : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            ICoffee coffee = new Espresso();
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            ICoffee coffee = new Filtered();
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            ICoffee coffee = new ChocolateDecorator(new Espresso());
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            ICoffee coffee = new ChocolateDecorator(new Filtered());
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            ICoffee coffee = new MilkDecorator(new Espresso());
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            ICoffee coffee = new MilkDecorator(new Filtered());
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            ICoffee coffee = new ChocolateDecorator(new MilkDecorator(new Filtered()));
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            ICoffee coffee = new ChocolateDecorator(new MilkDecorator(new Espresso()));
            Debug.Log("Coffee discription and cost: " + coffee.GetDescription() + " $" + coffee.GetCost());
        }
    }

    //game instructions
    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(10, 10, 500, 20), "A - Espresso, S - Filtered");
        GUI.Label(new Rect(10, 25, 500, 20), "D - Espresso w/ Chocolate, F - Filtered w/ Chocolate");
        GUI.Label(new Rect(10, 40, 500, 20), "Z - Espresso w/ Milk, X - Filtered w/ Milk");
        GUI.Label(new Rect(10, 55, 500, 20), "C - Espresso w/ Chocolate & Milk, V - Filtered w/ Chocolate & Milk");
        GUI.Label(new Rect(10, 70, 500, 20), "Implemented coffee instead. Output is in Debug.Log!");
    }
}
