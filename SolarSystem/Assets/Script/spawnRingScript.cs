using UnityEngine;
using System.Collections.Generic;

public class spawnRingScript : MonoBehaviour
{
    public int numObjectToSpawn;

    //radius from the center of the hole to the center of the torus tube
    public float radCenterToCenter;

    //the radius of the tube
    public float radTub;

    private System.Random rand;
    private float x, y, z;

    [SerializeField]
    private GameObject[] rockPrefab;

    //what is the range of the rotation speed x-min y-max
    [SerializeField]
    private Vector2 rotationSpeedRange;

    public List<GameObject> objects;

	// Use this for initialization
	void Start ()
    {
        //rand = new Random();
        rand = new System.Random();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        spawn();

    }

    void spawn()
    {

        float u = getRandomFloat(0, 2 * Mathf.PI);
        float v = getRandomFloat(0, 2 * Mathf.PI);

        x = (radCenterToCenter + radTub * Mathf.Cos(v)) * Mathf.Cos(u);
        z = (radCenterToCenter + radTub * Mathf.Cos(v)) * Mathf.Sin(u);
        y = 0/*radTub * Mathf.Sin(v)*/;

        //var t = GameObject.Instantiate(rockPrefab[getRandomInt(0, rockPrefab.Length)]);

        var rock = GameObject.Instantiate(rockPrefab[rand.Next(0, rockPrefab.Length-1)]);
        rock.transform.position = new Vector3(x, y, z);
        rock.GetComponent<rotationScript>().rotationAxis = new Vector3(getRandomFloat(0, 360), getRandomFloat(0, 360), getRandomFloat(0, 360));
        rock.GetComponent<rotationScript>().rotationPeriodInHours = getRandomFloat(rotationSpeedRange.x, rotationSpeedRange.y);
        objects.Add(rock);
    }

    float getRandomFloat(float min, float max)
    {
        return (float)(min + rand.NextDouble() * (max - min));
    }

    int getRandomInt(int min, int max)
    {
        var f = min + rand.Next() * (max - min);
        Debug.Log(min);
        return f;
    }
}
