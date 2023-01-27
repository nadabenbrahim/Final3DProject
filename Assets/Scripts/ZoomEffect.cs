using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomEffect : MonoBehaviour
{
    public Camera mainCamera;
    public float speed = 1;
    private bool buttonReleased;

    public void Update()
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
