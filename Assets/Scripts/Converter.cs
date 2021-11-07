using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Converter : MonoBehaviour
{
    public Text TempNumber;
    public Text TempSymbol;
    public static double FtoC(double f)
    {
        return (f - 32.0) / 1.8;
    }

    public static double CtoF(double c)
    {
        return 1.8 * c + 32.0;
    }

    //public void SetText (string text)
    //{
    //    Textfield.text = text;
    //}

    public void Convert()
    {
        if (TempSymbol.text == "°C") { 
        TempNumber.text = CtoF(double.Parse(TempNumber.text)).ToString();
            TempSymbol.text = "°F";
        }

        else
        {
            TempNumber.text = FtoC(double.Parse(TempNumber.text)).ToString();
            TempSymbol.text = "°C";
        }
    }


}
