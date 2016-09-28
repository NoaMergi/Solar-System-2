using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class SaturnCameraControlScript : MonoBehaviour
{
    [SerializeField]
    private float azimuthalCoordinate;
    [SerializeField]
    private float polarCoordinate;
    [SerializeField]
    private float radius;
    [SerializeField]
    private GameObject focus;

    [SerializeField]
    private float zoomVelocity;

    [SerializeField]
    private float moveVelocity;

    private float x, y, z;

    // Use this for initialization
    void Start ()
    {
        x = radius * Mathf.Cos(azimuthalCoordinate) * Mathf.Sin(polarCoordinate);
        z = radius * Mathf.Sin(azimuthalCoordinate) * Mathf.Sin(polarCoordinate);
        y = radius * Mathf.Cos(polarCoordinate);

        transform.position = new Vector3(x, y, z);

        transform.LookAt(focus.transform.position);

        InputSystemScript.mouseWheelDown += zoomOut;
        InputSystemScript.mouseWheelUp += zoomIn;
        InputSystemScript.mouseLeft += moveLeft;
        InputSystemScript.mouseRight += moveRight;
        InputSystemScript.mouseDown += moveDown;
        InputSystemScript.mouseUp += moveUp;


    }
	
	// Update is called once per frame
	void Update ()
    {
        x = radius * Mathf.Cos(azimuthalCoordinate) * Mathf.Sin(polarCoordinate);
        z = radius * Mathf.Sin(azimuthalCoordinate) * Mathf.Sin(polarCoordinate);
        y = radius * Mathf.Cos(polarCoordinate);

        transform.position = new Vector3(x, y, z);

        transform.LookAt(focus.transform.position);
    }

    void OnDestroy()
    {
        InputSystemScript.mouseWheelDown -= zoomOut;
        InputSystemScript.mouseWheelUp -= zoomIn;
        InputSystemScript.mouseLeft -= moveLeft;
        InputSystemScript.mouseRight -= moveRight;
        InputSystemScript.mouseDown -= moveDown;
        InputSystemScript.mouseUp -= moveUp;
    }

    void zoomOut()
    {
        if (radius < 50)
        {
            radius += zoomVelocity;
        }
    }

    void zoomIn()
    {
        if (radius > 1)
        {
            radius -= zoomVelocity;
        }
    }

    void moveLeft()
    {
        azimuthalCoordinate -= moveVelocity;
        azimuthalCoordinate %= -2 * Mathf.PI;

        //currentTime %= 1.0f;
    }

    void moveRight()
    {
        azimuthalCoordinate += moveVelocity;
        azimuthalCoordinate %= 2*Mathf.PI;
    }

    void moveUp()
    {
        polarCoordinate -= moveVelocity;
        polarCoordinate %= -2 * Mathf.PI;
    }

    void moveDown()
    {
        polarCoordinate += moveVelocity;
        polarCoordinate %= +2 * Mathf.PI;
    }
}
