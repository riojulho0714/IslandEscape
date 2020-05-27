using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunManager : MonoBehaviour
{
    [SerializeField] GameObject sunText;
    public GameObject backButton;
    [SerializeField] GameObject fireMake;
    public GameObject itembox1selected;

    void Start()
    {
        sunText.SetActive(true);
        backButton.SetActive(false);
        fireMake.SetActive(false);
    }


    // Textを押すと非表示
    public void OnPushSunTextButton()
    {
        sunText.SetActive(false);
        backButton.SetActive(true);
    }

    bool sw;

    public void BackButtonPush()
    {
        sw = true;
    }

    public void Shokika()
    {
        if (sw)
        {
            backButton.SetActive(true);
        }
    }

    public void FireAction()
    {
        if (itembox1selected.activeSelf)
        {
            fireMake.SetActive(true);
            sunText.SetActive(false);
            backButton.SetActive(true);
        }
    }
}
