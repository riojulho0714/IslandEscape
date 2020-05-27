﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanManager : MonoBehaviour
{
    [SerializeField] GameObject canImage;
    [SerializeField] GameObject alertText;
    [SerializeField] GameObject canButton;
    [SerializeField] GameObject itembox2;
    public GameObject itembox2selected;

    // 取得した後詳細表示
    [SerializeField] GameObject canImage2;
    [SerializeField] GameObject cantextPanel2;

    // 外部スクリプト
    [SerializeField] MirrorManager mirrorManager;
    [SerializeField] TreeBarkManager treebarkManager;
    [SerializeField] StonesManager stonesManager;
    [SerializeField] BranchesManager branchesManager;
    [SerializeField] SoilManager soilManager;
    [SerializeField] BananaManager bananaManager;

    public bool cansw;

    void Start()
    {
        CanSetActive(false);
        canButton.SetActive(true);
        itembox2.SetActive(false);
        cansw = false;
        itembox2selected.SetActive(false);

        // 取得した後詳細表示
        canImage2.SetActive(false);
        cantextPanel2.SetActive(false);

        // 外部スクリプト
        mirrorManager.GetComponentInParent<MirrorManager>();
        treebarkManager.GetComponentInParent<TreeBarkManager>();
        stonesManager.GetComponentInParent<StonesManager>();
        branchesManager.GetComponentInParent<BranchesManager>();
        soilManager.GetComponentInParent<SoilManager>();
        bananaManager.GetComponentInParent<BananaManager>();
    }

    void CanSetActive(bool isShow)
    {
        canImage.SetActive(isShow);
        alertText.SetActive(isShow);
    }

    // 落ちている缶詰を押すと缶詰とテキストを表示
    public void OnPushCanImageButton()
    {
        CanSetActive(true);
        canButton.SetActive(false);
        itembox2.SetActive(true);
        cansw = true;
    }

    // ImageかTextをクリックするとこれらを非表示
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

    // アイテムの選択
    public void SelectItem()
    {
        if (itembox2.activeSelf)
        {
            itembox2selected.SetActive(true);
            mirrorManager.itembox1selected.SetActive(false);
            treebarkManager.itembox3selected.SetActive(false);
            stonesManager.itembox4selected.SetActive(false);
            branchesManager.itembox5selected.SetActive(false);
            soilManager.itembox6selected.SetActive(false);
            bananaManager.itembox7selected.SetActive(false);
        }
    }

    // アイテムの詳細表示
    public void OpenDetail()
    {
        if (itembox2selected.activeSelf)
        {
            canImage2.SetActive(true);
            cantextPanel2.SetActive(true);
        }
    }

    // バツボタンを押すと詳細非表示
    public void CloseDetail()
    {
        canImage2.SetActive(false);
        cantextPanel2.SetActive(false);
    }
}
