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

            BoxCollider objBounds = objectToBeSpawned.GetComponent<BoxCollider>();

            Vector3 pos = getEmpteyPos(parent, objBounds);

            GameObject obj = Object.Instantiate(objectToBeSpawned, pos, Quaternion.identity, parent.transform) as GameObject;

            obj.transform.LookAt(parent.transform);
            obj.transform.Rotate(-90, 0, 0);


            container.Add(obj);
        }

        
    }
    
    private static Vector3 getEmpteyPos(GameObject parent, BoxCollider objBounds)
    {
        Vector3 pos;
        Collider[] objectsColidedWith;

        do
        {
            pos = Random.onUnitSphere * parent.GetComponent<SphereCollider>().radius + parent.transform.position;

            objectsColidedWith = Physics.OverlapBox(pos, new Vector3(objBounds.size.x, objBounds.size.y / 2, objBounds.size.z), Quaternion.identity);

        } while (objectsColidedWith.Length > 1);
        return pos;
    }

   
}
