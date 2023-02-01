using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ResourceManager : MonoBehaviour
{
    //UI
    [SerializeField] GameObject mainMenuUI;
    [SerializeField] GameObject spielUI;
    [SerializeField] GameObject spielBuildUI;
    [SerializeField] GameObject resourceUI;
    [SerializeField] GameObject optionUI;
    [SerializeField] GameObject mapUI;
    [SerializeField] GameObject achievementUI;
    [SerializeField] GameObject buildPattern;
    [SerializeField] GameObject cameraGame;
    [SerializeField] GameObject cameraMenu;
    [SerializeField] TextMeshProUGUI goldText;
    //Value
    public int Gold { get; private set; } = 50;

    private void Start()
    {
        goldText.text = Gold.ToString();
    }

    public void ShowMainMenu()
    {
        cameraMenu.SetActive(true);
        cameraGame.SetActive(false);
        mainMenuUI.SetActive(true);
        resourceUI.SetActive(false);
        spielUI.SetActive(false);
    }

    public void ShowOptionWindow()
    {
        optionUI.SetActive(true);
    }

    public void CloseOptionWindow()
    {
        optionUI.SetActive(false);
    }

    public void ShowAchievementWindow()
    {
        achievementUI.SetActive(true);
    }

    public void CloseAchievementWindow()
    {
        achievementUI.SetActive(false);
    }

    public void ShowGameUI()
    {
        cameraMenu.SetActive(false);
        cameraGame.SetActive(true);
        resourceUI.SetActive(true);
        spielUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void ShowMapUI()
    {
        mapUI.SetActive(true);
    }

    public void CloseMapUI()
    {
        mapUI.SetActive(false);
    }

    public void ActivateBuildPattern()
    {
        buildPattern.SetActive(true);
        spielUI.SetActive(false);
        spielBuildUI.SetActive(true);
    }

    public void DeactivateBuildPattern()
    {
        buildPattern.SetActive(false);
        spielBuildUI.SetActive(false);
        spielUI.SetActive(true);
    }

    public void AddResource(int value)
    {
        Gold += value;
        goldText.text = Gold.ToString();
    }

    public void SubResource(int value)
    {
        Gold -= value;
        goldText.text = Gold.ToString();
    }
}
