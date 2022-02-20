using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] _pointPrefab;
    public GameObject _hurddlePrefab;

    private void Start()
    {
        InvokeRepeating("PointSpawner", 4, Random.Range(10,15));
        InvokeRepeating("HurrdleSpawner", 10, Random.Range(10, 15));
    }
    private void PointSpawner()
    {
        Instantiate(_pointPrefab[Random.Range(0, 3)], transform.position, Quaternion.identity);
    }
    private void HurrdleSpawner()
    {
        Instantiate(_hurddlePrefab, transform.position = new Vector3(54.5f, Random.Range(-6f, 7f), 0), Quaternion.identity);
    }
}
