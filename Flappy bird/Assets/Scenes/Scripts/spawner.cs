using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;
    public float SpawnRate =1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), SpawnRate, SpawnRate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
