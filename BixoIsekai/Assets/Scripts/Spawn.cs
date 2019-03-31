using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy1;
    public float TempoSpawn;
    
    private Camera mainCamera;
    private float xMax, yMax;

    void Start()
    {
        mainCamera = Camera.main;
        xMax = mainCamera.orthographicSize * (mainCamera.aspect);
        yMax = mainCamera.orthographicSize;

        InvokeRepeating("SpawnTime", TempoSpawn, TempoSpawn);
    }
    
    private void SpawnTime()
    {
        
        Vector2 cameraPosition = new Vector2 (mainCamera.transform.position.x, mainCamera.transform.position.y);
        Vector2 spawnPosition = new Vector2(cameraPosition.x + Random.Range(-xMax, xMax), Random.Range(-yMax, yMax));
        
        
        
            Instantiate(Enemy1, spawnPosition, Quaternion.identity);
        
        
    }
    
}
