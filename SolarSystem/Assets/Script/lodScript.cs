using UnityEngine;
using System.Collections;

public class lodScript : MonoBehaviour
{

    [SerializeField]
    private cameraOrbitControlScript currentCamera;

    [SerializeField]
    private GameObject lowPoly;
    private Transform [] lowPolyChildren;

    [SerializeField]
    private GameObject highPoly;
    private Transform[] highPolyChildren;

    [SerializeField]
    private float distanceThreshold;


	// Use this for initialization
	void Start ()
    {
        lowPolyChildren = lowPoly.transform.GetComponentsInChildren<Transform>();
        highPolyChildren = highPoly.transform.GetComponentsInChildren<Transform>();
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

    void changeSatusLowPoly()
    {

    }
}
