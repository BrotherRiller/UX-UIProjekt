using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class BauMenu : MonoBehaviour
{
    [SerializeField] GameObject buildUI;
    [SerializeField] Button closeButton;

    private void Start()
    {
        closeButton.onClick.AddListener(CloseUI);
    }

    private void OnMouseDown()
    {
        buildUI.SetActive(true);
    }

    public void CloseUI()
    {
        buildUI.SetActive(false);
    }
}
