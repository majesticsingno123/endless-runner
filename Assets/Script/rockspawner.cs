using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockspawner : MonoBehaviour
{
    public GameObject rockPrefab;
    public float score;
    public float shownscore;
    public int count;
    public GameObject[] rocks;
    public int i;
    public float tempPosition;
    public Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.Find("Player").transform;
        rocks = new GameObject[15];
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

   
 private IEnumerator spawn()
    {
         while (true)
        {
            for (i = 0; i < 10; i++)
            {
                if (rocks[i] == null)
                {
                    float randomX = UnityEngine.Random.Range(0.5f, 9.5f);
                    float timeRandom = UnityEngine.Random.Range(0.1f, 3f);

                    while (tempPosition == randomX)
                    {
                        randomX = UnityEngine.Random.Range(-4.5f, 4.5f);
                    }

                    Vector3 rockPosition = new Vector3(randomX, 1.6f, playerPos.position.z + 150f);
                    tempPosition = randomX;
                    rocks[i] = (GameObject)Instantiate(rockPrefab, rockPosition, Quaternion.identity);
                    Destroy(rocks[i], 6f);
                    yield return new WaitForSeconds(timeRandom);
                }
            }
        }       
    }
}
