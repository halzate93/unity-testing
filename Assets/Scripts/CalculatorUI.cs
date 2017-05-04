using UnityEngine;

public class CalculatorUI: MonoBehaviour
{
    private Calculator calculator;

    private void Awake ()
    {
        NumberParser parser = new NumberParser ();
        calculator = new Calculator (parser);
    }

}