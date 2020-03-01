using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    public GameObject[] items;
    
    void Start()
    {
        int i = Random.Range(0, items.Length);
        Instantiate(items[i], transform.position, Quaternion.identity);
    }
}
