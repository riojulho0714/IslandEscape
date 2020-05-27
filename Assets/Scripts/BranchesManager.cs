using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchesManager : MonoBehaviour
{
	[SerializeField] GameObject branchesImage;
	[SerializeField] GameObject alertText;
    [SerializeField] GameObject branchesButton;
    [SerializeField] GameObject itembox5;
    public GameObject itembox5selected;

    // 取得した後詳細表示
    [SerializeField] GameObject branchesImage2;
    [SerializeField] GameObject branchestextPanel2;

    // 外部スクリプト
    [SerializeField] MirrorManager mirrorManager;
    [SerializeField] CanManager canManager;
    [SerializeField] TreeBarkManager treebarkManager;
    [SerializeField] StonesManager stonesManager;
    [SerializeField] SoilManager soilManager;
    [SerializeField] BananaManager bananaManager;

    public bool branchessw;

    void Start()
    {
		BranchesSetActive(false);
        branchesButton.SetActive(true);
        itembox5.SetActive(false);
        branchessw = false;
        itembox5selected.SetActive(false);

        // 取得した後詳細表示
        branchesImage2.SetActive(false);
        branchestextPanel2.SetActive(false);

        // 外部スクリプト
        mirrorManager.GetComponentInParent<MirrorManager>();
        canManager.GetComponentInParent<CanManager>();
        treebarkManager.GetComponentInParent<TreeBarkManager>();
        stonesManager.GetComponentInParent<StonesManager>();
        soilManager.GetComponentInParent<SoilManager>();
        bananaManager.GetComponentInParent<BananaManager>();
    }

	void BranchesSetActive(bool isShow)
	{
		branchesImage.SetActive(isShow);
		alertText.SetActive(isShow);
	}

	// 落ちている小枝を押すと小枝とテキストを表示
	public void OnPushBranchesImageButton()
	{
		BranchesSetActive(true);
        branchesButton.SetActive(false);
        itembox5.SetActive(true);
        branchessw = true;
    }

    // ImageかTextをクリックするとこれらを非表示
    bool sw;

	public void BranchesImagePush()
	{
		sw = true;
	}

	public void BranchesTextPush()
	{
		sw = true;
	}

	void Update()
	{
		if (sw)
		{
			BranchesSetActive(false);
		}
	}

    // アイテムの選択
    public void SelectItem()
    {
        if (itembox5.activeSelf)
        {
            itembox5selected.SetActive(true);
            mirrorManager.itembox1selected.SetActive(false);
            canManager.itembox2selected.SetActive(false);
            treebarkManager.itembox3selected.SetActive(false);
            stonesManager.itembox4selected.SetActive(false);
            soilManager.itembox6selected.SetActive(false);
            bananaManager.itembox7selected.SetActive(false);
        }
    }

    // アイテムの詳細表示
    public void OpenDetail()
    {
        if (itembox5selected.activeSelf)
        {
            branchesImage2.SetActive(true);
            branchestextPanel2.SetActive(true);
        }
    }

    // バツボタンを押すと詳細非表示
    public void CloseDetail()
    {
        branchesImage2.SetActive(false);
        branchestextPanel2.SetActive(false);
    }
}
