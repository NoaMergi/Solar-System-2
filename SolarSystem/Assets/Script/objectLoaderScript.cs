using UnityEngine;
using System.Collections.Generic;

public static class objectLoaderScript
{

    static System.Random rand = new System.Random();


	public static void generateBuilding(GameObject parent, int dencity, List<GameObject> container, List<GameObject> choicesList)
    {
        
        for (int i = 0; i < dencity; ++i)
        {
            GameObject objectToBeSpawned = choicesList[rand.Next(0, choicesList.Count - 1)];
            //float y = objectToBeSpawned.GetComponent<Renderer>().bounds.size.y;
            Vector3 pos = Random.onUnitSphere * parent.GetComponent<SphereCollider>().radius + parent.transform.position;
            Debug.Log(pos);

            GameObject obj = Object.Instantiate(objectToBeSpawned, pos, Quaternion.identity, parent.transform) as GameObject;


            //obj.transform.position = pos;
            obj.transform.LookAt(parent.transform);
            obj.transform.Rotate(-90, 0, 0);
        }
    }

}
