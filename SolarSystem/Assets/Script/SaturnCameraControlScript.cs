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

    private float x, y, z;

    // Use this for initialization
    void Start ()
    {
        x = radius * Mathf.Cos(azimuthalCoordinate) * Mathf.Sin(polarCoordinate);
        z = radius * Mathf.Sin(azimuthalCoordinate) * Mathf.Sin(polarCoordinate);
        y = radius * Mathf.Cos(polarCoordinate);

        transform.position = new Vector3(x, y, z);

        transform.LookAt(focus.transform.position);

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
}
