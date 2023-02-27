using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        if (coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }
        else if (coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}