using UnityEngine;
using System.Collections.Generic;
using System;

public class planetObjectContainerScript : MonoBehaviour
{
    [HideInInspector]
    public List<GameObject> buildings;

    public List<GameObject> buildingTypes;

    [SerializeField]
    private int buildingDencity;


    //by what amount add or remove buildings 
    [SerializeField]
    private int changeInDencity;

    [SerializeField]
    private int buildingMax;


    void Awake()
    {
        buildings = new List<GameObject>();
    }

	// Use this for initialization
	void Start ()
    {
        objectLoaderScript.generateBuilding(gameObject, buildingDencity, buildings, buildingTypes);
        //emptyPlanet();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void emptyPlanet()
    {
        for (int i = 0; i < buildings.Count; ++i)
        {
            Destroy(buildings[i]);
        }
        buildings.Clear();
    }


    public void addBuildings()
    {
        emptyPlanet();
        buildingDencity += changeInDencity;
        idiotProf();
        objectLoaderScript.generateBuilding(gameObject, buildingDencity, buildings, buildingTypes);
        Debug.Log(buildingDencity);
    }

    public void removeBuildings()
    {
        emptyPlanet();
        buildingDencity -= changeInDencity;
        idiotProf();
        objectLoaderScript.generateBuilding(gameObject, buildingDencity, buildings, buildingTypes);
        Debug.Log(buildingDencity);
    }

    public void switchChangeInDencity(string value)
    {
        changeInDencity = Int32.Parse(value);
    }

    private void idiotProf()
    {
        if (buildingDencity < 0)
            buildingDencity = 0;
        else if (buildingDencity > buildingMax)
            buildingDencity = buildingMax;
    }
}
