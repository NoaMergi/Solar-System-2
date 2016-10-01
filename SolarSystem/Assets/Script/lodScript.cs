using UnityEngine;
using System.Collections;

public class lodScript : MonoBehaviour
{

    [SerializeField]
    private cameraOrbitControlScript currentCamera;

    [SerializeField]
    private GameObject lowPoly;

    [SerializeField]
    private GameObject highPoly;

    [SerializeField]
    private float distanceThreshold;


	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (currentCamera.getCameraDistance() < distanceThreshold)
        {
            highPoly.SetActive(true);
            lowPoly.SetActive(false);
        }
        else
        {
            highPoly.SetActive(false);
            lowPoly.SetActive(true);
        }
	}

}
