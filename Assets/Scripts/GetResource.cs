using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetResource : MonoBehaviour
{
    [SerializeField] int income;
    private ResourceManager res;

    private void Awake()
    {
        res = GameObject.Find("ResourceManagement").GetComponent<ResourceManager>();
        InvokeRepeating("Add", 1, 1);
    }

    void Add()
    {
        res.AddResource(income);
    }
}
