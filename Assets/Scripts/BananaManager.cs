﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaManager : MonoBehaviour
{
	[SerializeField] GameObject bananaImage;
	[SerializeField] GameObject alertText;
	public GameObject bananaPanel;
	public GameObject panel6;
	public GameObject itemBox;
    [SerializeField] GameObject itembox7;
    public GameObject itembox7selected;

    // 取得した後詳細表示
    [SerializeField] GameObject bananaImage2;
    [SerializeField] GameObject bananatextPanel2;

    // 外部スクリプト
    [SerializeField] MirrorManager mirrorManager;
    [SerializeField] CanManager canManager;
    [SerializeField] TreeBarkManager treebarkManager;
    [SerializeField] StonesManager stonesManager;
    [SerializeField] BranchesManager branchesManager;
    [SerializeField] SoilManager soilManager;

    public bool bananasw;

    void Start()
	{
		BananaSetActive(false);
        itembox7.SetActive(false);
        bananasw = false;
        itembox7selected.SetActive(false);

        // 取得した後詳細表示
        bananaImage2.SetActive(false);
        bananatextPanel2.SetActive(false);

        // 外部スクリプト
        mirrorManager.GetComponentInParent<MirrorManager>();
        canManager.GetComponentInParent<CanManager>();
        treebarkManager.GetComponentInParent<TreeBarkManager>();
        stonesManager.GetComponentInParent<StonesManager>();
        branchesManager.GetComponentInParent<BranchesManager>();
        soilManager.GetComponentInParent<SoilManager>();
    }

	void BananaSetActive(bool isShow)
	{
		bananaImage.SetActive(isShow);
		alertText.SetActive(isShow);
	}

	// バナナを押すとバナナとテキストを表示
	public void OnPushBananaImageButton()
	{
		BananaSetActive(true);
        itembox7.SetActive(true);
        bananasw = true;
    }

    // ImageかTextをクリックするとこれらを非表示
    bool sw;

	public void BananaImagePush()
	{
		sw = true;
	}

	public void BananaTextPush()
	{
		sw = true;
	}

	void FixedUpdate()
	{
		if (sw)
		{
			BananaSetActive(false);
			bananaPanel.SetActive(false);
			panel6.SetActive(true);
			itemBox.SetActive(true);
		}
	}

    // アイテムの選択
    public void SelectItem()
    {
        if (itembox7.activeSelf)
        {
            itembox7selected.SetActive(true);
            mirrorManager.itembox1selected.SetActive(false);
            canManager.itembox2selected.SetActive(false);
            treebarkManager.itembox3selected.SetActive(false);
            stonesManager.itembox4selected.SetActive(false);
            branchesManager.itembox5selected.SetActive(false);
            soilManager.itembox6selected.SetActive(false);
        }
    }

    // アイテムの詳細表示
    public void OpenDetail()
    {
        if (itembox7selected.activeSelf)
        {
            bananaImage2.SetActive(true);
            bananatextPanel2.SetActive(true);
        }
    }

    // バツボタンを押すと詳細非表示
    public void CloseDetail()
    {
        bananaImage2.SetActive(false);
        bananatextPanel2.SetActive(false);
    }
}


