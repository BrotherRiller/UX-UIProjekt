using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUI : MonoBehaviour
{
    [SerializeField] GameObject UI;
    [SerializeField] GameObject RecruitUI;
    [SerializeField] GameObject selected;
    [SerializeField] GameObject recruit;
    [SerializeField] int sellPrice;

    private ResourceManager res;

    private void Awake()
    {
        res = GameObject.Find("ResourceManagement").GetComponent<ResourceManager>();
    }

    private void OnMouseDown()
    {
        if (!res.isClickable)
        {
            return;
        }
        selected.SetActive(true);
        UI.SetActive(true);
        res.isClickable = false;    
    }

    public void CloseUI()
    {
        selected.SetActive(false);
        UI.SetActive(false);
        res.isClickable = true;
    }

    public void ShowRecruitWindow()
    {
        UI.SetActive(false);
        selected.SetActive(false);
        RecruitUI.SetActive(true);
    }

    public void CloseRecruitWindow()
    {
        RecruitUI.SetActive(false);
        res.isClickable = true;
    }

    public void SellBuilding()
    {
        res.AddResource(sellPrice);
        res.isClickable = true;
        Destroy(this.gameObject);
    }

    public void Recruit()
    {
        if(res.Gold < 10)
        {
            return;
        }
        Instantiate(recruit, transform.position, Quaternion.identity);
        res.SubResource(10);
    }
}
