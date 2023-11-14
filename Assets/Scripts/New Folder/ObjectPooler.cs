using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler Instance { get; private set; }

    public GameObject pooledObject;
    public int poolSize = 10;

    private List<GameObject> pooledObjects;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        return null;
    }
}


