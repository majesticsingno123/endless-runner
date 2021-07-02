using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObstacles : MonoBehaviour
{
    public GameObject ObstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        ObstaclePrefab.transform.position = new Vector3(Random.Range(0, 9 - ObstaclePrefab.transform.localScale.x), ObstaclePrefab.transform.position.y, ObstaclePrefab.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
