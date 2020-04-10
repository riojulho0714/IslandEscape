using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaManager : MonoBehaviour
{
    [SerializeField] GameObject seaImage;
    public GameObject backButton;


    void Start()
    {
        SeaSetActive(false);
        backButton.SetActive(true);
    }

    void SeaSetActive(bool isShow)
    {
        seaImage.SetActive(isShow);
    }

    // 海を押すと画像を表示
    public void OnPushSeaImageButton()
    {
        SeaSetActive(true);
        backButton.SetActive(false);
    }

    // 画像を押すと非表示
    public void SeaImagePush()
    {
        SeaSetActive(false);
        backButton.SetActive(true);
    }
}
