using UnityEngine;
using System.Collections.Generic;

public class cameraControlScript : MonoBehaviour 
{

   public List<Camera> cameras;

	// Use this for initialization
	void Start () 
    {
        unableCameras();
        activateCamera0();

        if (cameras.Count >= 0)
        {
            inputSystemScript.N1 += activateCamera0;
        }
        if (cameras.Count >= 1)
        {
            inputSystemScript.N2 += activateCamera1;
        }
        if (cameras.Count >= 2)
        {
            inputSystemScript.N3 += activateCamera2;
        }
        if (cameras.Count >= 3)
        {
            inputSystemScript.N4 += activateCamera3;
        }
    }
	
	// Update is called once per frame
	void Update () 
    {
        
    }

    void unableCameras()
    {
        foreach (var camera in cameras)
        {
            camera.GetComponent<Camera>().enabled = false;
        }
    }

    void OnDestroy()
    {
        inputSystemScript.N1 -= activateCamera0;
        inputSystemScript.N2 -= activateCamera1;
        inputSystemScript.N3 -= activateCamera2;
        inputSystemScript.N4 -= activateCamera3;
    }

    void activateCamera0()
    {
        unableCameras();
        cameras[0].enabled = true;
    }
    void activateCamera1()
    {
        unableCameras();
        cameras[1].enabled = true;
    }
    void activateCamera2()
    {
        unableCameras();
        cameras[2].enabled = true;
    }
    void activateCamera3()
    {
        unableCameras();
        cameras[3].enabled = true;
    }
    void activateCamera4()
    {
        unableCameras();
        cameras[4].enabled = true;
    }
}
