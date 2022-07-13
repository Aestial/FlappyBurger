using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float spawnInterval = 1.0f;
    [SerializeField] private float spawnDelay = 0.0f;
    [SerializeField] private float heightVariation;
    [SerializeField] private float heightVariationOffset;
    [SerializeField] private float gapDistance = 3.0f;

    void OnEnable() 
    {
        InvokeRepeating("Spawn", spawnDelay, spawnInterval);
    }
    void OnDisable()
    {
        CancelInvoke("Spawn");
        DestroyAll();
    }

    private void DestroyAll()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }

    private void Spawn()
    {
        GameObject obstacle = Instantiate(obstaclePrefab, transform);
        obstacle.transform.localPosition = new Vector2(0, heightVariation * Random.Range(-1, 1) + heightVariationOffset);
        obstacle.GetComponent<GapDistance>().distance = gapDistance;
    }
}
