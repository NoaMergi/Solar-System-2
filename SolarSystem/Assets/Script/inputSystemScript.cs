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
    public static event inputSystem N1 = delegate { };
    public static event inputSystem N2 = delegate { };
    public static event inputSystem N3 = delegate { };
    public static event inputSystem N4 = delegate { };
    public static event inputSystem N5 = delegate { };
    public static event inputSystem N6 = delegate { };
    public static event inputSystem N7 = delegate { };
    public static event inputSystem N8 = delegate { };
    public static event inputSystem N9 = delegate { };
    public static event inputSystem N0 = delegate { };

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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            N1.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            N2.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            N3.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            N4.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            N5.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            N6.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            N7.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            N8.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            N9.Invoke();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            N0.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
