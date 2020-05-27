using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesManager : MonoBehaviour
{
    [SerializeField] GameObject stonesImage;
    [SerializeField] GameObject alertText;
    [SerializeField] GameObject stonesButton;
    [SerializeField] GameObject itembox4;
    public GameObject itembox4selected;

    // 取得した後詳細表示
    [SerializeField] GameObject stonesImage2;
    [SerializeField] GameObject stonestextPanel2;

    // 外部スクリプト
    [SerializeField] MirrorManager mirrorManager;
    [SerializeField] CanManager canManager;
    [SerializeField] TreeBarkManager treebarkManager;
    [SerializeField] BranchesManager branchesManager;
    [SerializeField] SoilManager soilManager;
    [SerializeField] BananaManager bananaManager;

    public bool stonessw;

    void Start()
    {
        StonesSetActive(false);
        stonesButton.SetActive(true);
        itembox4.SetActive(false);
        stonessw = false;
        itembox4selected.SetActive(false);

        // 取得した後詳細表示
        stonesImage2.SetActive(false);
        stonestextPanel2.SetActive(false);

        // 外部スクリプト
        mirrorManager.GetComponentInParent<MirrorManager>();
        canManager.GetComponentInParent<CanManager>();
        treebarkManager.GetComponentInParent<TreeBarkManager>();
        branchesManager.GetComponentInParent<BranchesManager>();
        soilManager.GetComponentInParent<SoilManager>();
        bananaManager.GetComponentInParent<BananaManager>();

    }

    void StonesSetActive(bool isShow)
    {
        stonesImage.SetActive(isShow);
        alertText.SetActive(isShow);
    }

    // 落ちている石を押すと石とテキストを表示
    public void OnPushStonesImageButton()
    {
        StonesSetActive(true);
        stonesButton.SetActive(false);
        itembox4.SetActive(true);
        stonessw = true;
    }

    // ImageかTextをクリックするとこれらを非表示
    bool sw;

    public void StonesImagePush()
    {
        sw = true;
    }

    public void StonesTextPush()
    {
        sw = true;
    }

    void Update()
    {
        if (sw)
        {
            StonesSetActive(false);
        }
    }

    // アイテムの選択
    public void SelectItem()
    {
        if (itembox4.activeSelf)
        {
            itembox4selected.SetActive(true);
            mirrorManager.itembox1selected.SetActive(false);
            canManager.itembox2selected.SetActive(false);
            treebarkManager.itembox3selected.SetActive(false);
            branchesManager.itembox5selected.SetActive(false);
            soilManager.itembox6selected.SetActive(false);
            bananaManager.itembox7selected.SetActive(false);
        }
    }

    // アイテムの詳細表示
    public void OpenDetail()
    {
        if (itembox4selected.activeSelf)
        {
            stonesImage2.SetActive(true);
            stonestextPanel2.SetActive(true);
        }
    }

    // バツボタンを押すと詳細非表示
    public void CloseDetail()
    {
        stonesImage2.SetActive(false);
        stonestextPanel2.SetActive(false);
    }
}
