using UnityEngine;
using System.Collections.Generic;

public class planetObjectContainerScript : MonoBehaviour
{
    [HideInInspector]
    public List<GameObject> buildings;

    public List<GameObject> buildingTypes;

    public int buildingDencity;

    void Awake()
    {
        buildings = new List<GameObject>();
    }

	// Use this for initialization
	void Start ()
    {
        objectLoaderScript.generateBuilding(gameObject, buildingDencity, buildings, buildingTypes);

        

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
