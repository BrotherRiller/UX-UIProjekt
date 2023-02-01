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

    private void Start()
    {
        res = GameObject.Find("ResourceManagement").GetComponent<ResourceManager>();
    }

    private void OnMouseDown()
    {
        selected.SetActive(true);
        UI.SetActive(true);
    }

    public void CloseUI()
    {
        selected.SetActive(false);
        UI.SetActive(false);
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
    }

    public void SellBuilding()
    {
        res.AddResource(sellPrice);
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
