using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemanager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    private Transform playerTransform;
    private float spawnZ = -80.0f;
    private float titleLength = 80.0f;
    private float safeZone = 75.0f;
    private int amnTilesOnScreen = 7;
    private int lastPrefabIndex = 0;

    public List<GameObject> activesTiles;
    // Start is called before the first frame update
    void Start()
    {
        activesTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amnTilesOnScreen; i++)
        {

            SpawnTile();

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * titleLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;

        go = Instantiate(tilePrefabs[RandomPrefabIndex()]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += titleLength;
        activesTiles.Add(go);
    }
    private void DeleteTile()
    {
        Destroy(activesTiles[0]);
        activesTiles.RemoveAt(0);
    }
    private int RandomPrefabIndex()
    {
        int randomIndex = lastPrefabIndex;

        if (tilePrefabs.Length <= 1)
            return 0;

        else
        {
            randomIndex = Random.Range(0, tilePrefabs.Length);
        }        
        lastPrefabIndex = randomIndex;
        return randomIndex;
    }

}
