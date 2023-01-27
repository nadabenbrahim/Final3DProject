using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClick : MonoBehaviour
{
    //public ZoomEffect zoomIn;
    public GameObject panel ;
    public GameObject planet;
    public Camera mainCamera;
    public float speed = 1;
    private bool buttonReleased;
    public string infoText;



    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {   RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray,out hit,150.0f))
            {   if(hit.transform != null)
                {
                    PrintName(hit.transform.gameObject);
                }
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            {
                print(mousePos.x);
                print(mousePos.y);
            }
        }
    }

    void PrintName(GameObject go)
    {
        print(go.name);
        switch (go.tag)
        {
            case "mercury":
            // Display the information on the Text UI element
                infoText = "This is Mercury. \n Mercury is 57 million km away from the Sun. \n It weights 3.3022 x 1023 kilograms. \n The atmosphere of this planet is composed of sodium and potassium gas.";
                break;
            case "Venus":
            // Display the information on the Text UI element
                infoText = "This is Venus. Venus is 108 million km away from the Sun. \n It weights 4.8685 x 1024 kilograms. \n The atmosphere of this planet is composed mainly of carbon dioxide with minor amounts of nitrogen and trace amounts of nitrogen, helium, neon, and argon.  ";
                break;
            case "earth":
            // Display the information on the Text UI element
                infoText = "This is the Earth. \n Earth is 150 million km away from the Sun. \n It weights 5.9736 x 1024 kilograms.\n The atmosphere primarily composed of nitrogen and oxygen. Minor gases include and carbon dioxide, ozone, argon, and helium.";
                break;
            case "Mars":
            // Display the information on the Text UI element
                infoText = "This is the Mars. \n Mars is 228 million km away from the Sun. \n It weights 6.4185 x 1023 kilograms. \n The atmosphere is a thin layer composed mainly of carbon dioxide. Nitrogen, argon, and small traces of oxygen and water vapor are also present.";
                break;
            case "Jupiter":
            // Display the information on the Text UI element
                infoText = "This is the Jupiter. \n Jupiter is 779 million km away from the Sun. \n It weights 1.8986 x 1027 kilograms. \n The atmosphere contains mainly helium and hydrogen with trace amounts of water, ammonia, methane, and other carbon compounds.";
                break;
            case "Saturn":
            // Display the information on the Text UI element
                infoText = "This is the Saturn. Saturn is 1.43 billion km away from the Sun. \n It weights 5.6846 x 1026 kilograms. \n The atmosphere is thick, it is composed of hydrogen and helium";
                break;
            case "Uranus":
            // Display the information on the Text UI element
                infoText = "This is the Uranus. Uranus is 2.88 billion km away from the Sun. \n It weights 8.6810 x 1025 kilograms. \n The atmosphere is composed mainly of hydrogen and minor amounts of helium Methane is present in minor amounts, and probably forms most of the clouds seen by space probes and telescopes.";
                break;
            case "Neptune":
            // Display the information on the Text UI element
                infoText = "This is the Neptune. Neptune is  4.50 billion km away from the Sun. \n It weights 10.243 x 1025 kilograms. \n The atmosphere consists mainly of hydrogen and helium, but about 2.5-3% of the atmosphere is methane.";
                break;
            case "Sun":
            // Display the information on the Text UI element
                infoText = "This is the Sun. \n It's the center of the Solar System. \n It is the only star and its gravity holds the Solar System together.";
                break;
            case "Moon":
            // Display the information on the Text UI element
                infoText = "This is the Moon. \n It follows the Earth while turning arround it. \n It is the only natural satelite of the Earth.";
                break;


        }
    }
 	void OnGUI()
 	{
         GUI.Label(new Rect(150,50,750,300), infoText);
	 GUI.skin.label.fontSize=50;

	}

    public void ZoomIn()
    {
        if (Input.GetMouseButton(1))
        {
            buttonReleased = false;

            if(mainCamera.fieldOfView >= 45)
            {
                mainCamera.fieldOfView -= 1;
            }

        }

        if (Input.GetMouseButtonUp(1)){
            buttonReleased = true;
        }

        if (buttonReleased)
        {
            if(mainCamera.fieldOfView <= 70)
            {
                mainCamera.fieldOfView += 1;
            }
        }

    }
}
