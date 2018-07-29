using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Steam : MonoBehaviour {

    public float SteamAmount;
    public GameObject SlideBar;

    private void Update()
    {
        //SlideBar.GetComponent<Image>().fillAmount = SteamAmount;
    }

    public float GetSteamAmount()
    {
        return SlideBar.GetComponent<Image>().fillAmount;
    }

    public void DecreaseAmountOfSteam(float amount)
    {
        SteamAmount -= amount;
        SlideBar.GetComponent<Image>().fillAmount = SteamAmount / 100f;
    }
    public void RefillSteam()
    {
        SteamAmount = 100;
        SlideBar.GetComponent<Image>().fillAmount = SteamAmount / 100f;
    }
}
