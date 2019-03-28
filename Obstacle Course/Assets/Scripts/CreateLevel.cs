using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{
	public Object[] obstacles;
	public Object obstacle;

    // Start is called before the first frame update
    void Start()
    {
    	for (int i = 1; i <= 100; i ++) {
        	Instantiate(pickObstacle(), new Vector3(-3, 0, (i * 20)-1), Quaternion.identity); 
        }
    }

    Object pickObstacle() {
    	int objectIndex = Random.Range(0,obstacles.Length);
        obstacle = obstacles[objectIndex];
    	return obstacle;
    }
}
