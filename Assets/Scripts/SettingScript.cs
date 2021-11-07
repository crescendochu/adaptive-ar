using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //for using button functions


public class SettingScript : MonoBehaviour

{
    public Camera cam; 
    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();
    public GameObject settings, converter;
    public bool on;

    // Start is called before the first frame update
    void Start()
    {
        definedButton = this.gameObject;
        settings.SetActive(true);
        converter.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * Time.deltaTime * 100);

        var ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.DrawRay(ray.origin, ray.direction, Color.red);

            if(Physics.Raycast(ray,out Hit) && Hit.collider.gameObject == gameObject)
            {

                if (on == false)
                {
                    //Debug.Log("Button Clicked");
                    converter.SetActive(true);
                    on = true;
                }

                else
                {
                    converter.SetActive(false);
                    on = false;
                }
                
                


            }

        }
    }
}
