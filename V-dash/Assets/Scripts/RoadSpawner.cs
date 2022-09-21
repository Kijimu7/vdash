using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> roads; //road prefabs
    private float offset = 10f; //length of the road
    // Start is called before the first frame update
    void Start()
    {
        if(roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(r => r.transform.position.z).ToList(); //make it in right order
        }
    }

   public void MoveRoad() //move road
    {
        GameObject movedRoad = roads[0]; //take first road and reposition it, taking first element of the list
        roads.Remove(movedRoad); //remove the first element of the list
        float newZ = roads[roads.Count - 1].transform.position.z + offset; //calculate the new Z value based on the last elements postion and the offset
        movedRoad.transform.position = new Vector3(0, 0, newZ);
        roads.Add(movedRoad);
    }
}
 