using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanManager : MonoBehaviour
{
    [SerializeField] GameObject canImage;
    [SerializeField] GameObject alertText;

    void Start()
    {
        CanSetActive(false);
    }

    void CanSetActive(bool isShow)
    {
        canImage.SetActive(isShow);
        alertText.SetActive(isShow);
    }

    //落ちている缶詰を押すと缶詰とテキストを表示
    public void OnPushCanImageButton()
    {
        CanSetActive(true);
    }

    //ImageかTextをクリックするとこれらを非表示
    bool sw;

    public void CanImagePush()
    {
        sw = true;
    }

    public void CanTextPush()
    {
        sw = true;
    }

    void Update()
    {
        if (sw)
        {
            CanSetActive(false);
        }
    }
}
