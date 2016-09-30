using UnityEngine;
using System.Collections;


public class inputSystemScript : MonoBehaviour
{
    public delegate void inputSystem();
    public static event inputSystem mouseWheelUp = delegate { };
    public static event inputSystem mouseWheelDown = delegate { };
    public static event inputSystem mouseLeft = delegate { };
    public static event inputSystem mouseRight = delegate { };
    public static event inputSystem mouseUp = delegate { };
    public static event inputSystem mouseDown = delegate { };

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Mouse X") < 0)
        {
            //print("Mouse moved left");
            mouseLeft.Invoke();
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            //print("Mouse moved right");
            mouseRight.Invoke();
        }
        if (Input.GetAxis("Mouse Y") < 0)
        {
            //print("Mouse moved down");
            mouseUp.Invoke();
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            //print("Mouse moved up");
            mouseDown.Invoke();
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            //print("scroll up");
            mouseWheelUp.Invoke();
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            //print("scroll down");
            mouseWheelDown.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
