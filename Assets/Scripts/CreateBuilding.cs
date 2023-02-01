using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CreateBuilding : MonoBehaviour
{
    [SerializeField] GameObject bohrer;
    [SerializeField] GameObject wohnhaus;
    [SerializeField] GameObject headquarter;
    [SerializeField] GameObject oil;
    [SerializeField] GameObject feld;
    [SerializeField] GameObject buildUI;

    private ResourceManager res;

    private void Start()
    {
        res = GameObject.Find("ResourceManagement").GetComponent<ResourceManager>();
    }

    public void BuildBohrer()
    {
        if(res.Gold < 10)
        {
            return;
        }
        res.SubResource(10);
        Instantiate(bohrer, feld.transform.position, Quaternion.identity);
        buildUI.SetActive(false);
        
    }

    public void BuildWohnhaus()
    {
        if (res.Gold < 50)
        {
            return;
        }
        res.SubResource(50);
        Instantiate(wohnhaus, feld.transform.position, Quaternion.identity);
        buildUI.SetActive(false);
        
    }

    public void BuildHeadquarter()
    {
        if(res.Gold < 100)
        {
            return;
        }
        res.SubResource(100);
        Instantiate(headquarter, feld.transform.position, Quaternion.identity);
        buildUI.SetActive(false);
    }

    public void BuildOilBuilding()
    {
        if (res.Gold < 50)
        {
            return;
        }
        res.SubResource(50);
        Instantiate(oil, feld.transform.position, Quaternion.identity);
        buildUI.SetActive(false);
    }
}
