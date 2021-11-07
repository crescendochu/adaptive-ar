using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //for using button functions
using UnityEngine.UI;

public class Converter3D : MonoBehaviour

{
    public Camera cam;
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
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

    // Start is called before the first frame update
    void Start()
    {
        definedButton = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red);

            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                //Debug.Log("New Click");
                if (TempSymbol.text == "°C")
                {
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


        }
    }
