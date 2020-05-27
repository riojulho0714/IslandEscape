using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorManager : MonoBehaviour
{
    [SerializeField] GameObject mirrorImage;
    [SerializeField] GameObject alertText;
    [SerializeField] GameObject mirrorButton;
    [SerializeField] GameObject itembox1;
    public GameObject itembox1selected;

    // 取得した後詳細表示
    [SerializeField] GameObject mirrorImage2;
    [SerializeField] GameObject mirrortextPanel2;

    // 外部スクリプト
    [SerializeField] CanManager canManager;
    [SerializeField] TreeBarkManager treebarkManager;
    [SerializeField] StonesManager stonesManager;
    [SerializeField] BranchesManager branchesManager;
    [SerializeField] SoilManager soilManager;
    [SerializeField] BananaManager bananaManager;

    public bool mirrorsw;

    void Start()
    {
        MirrorSetActive(false);
        mirrorButton.SetActive(true);
        itembox1.SetActive(false);
        mirrorsw = false;
        itembox1selected.SetActive(false);

        // 取得した後詳細表示
        mirrorImage2.SetActive(false);
        mirrortextPanel2.SetActive(false);

        // 外部スクリプト
        canManager.GetComponentInParent<CanManager>();
        treebarkManager.GetComponentInParent<TreeBarkManager>();
        stonesManager.GetComponentInParent<StonesManager>();
        branchesManager.GetComponentInParent<BranchesManager>();
        soilManager.GetComponentInParent<SoilManager>();
        bananaManager.GetComponentInParent<BananaManager>();
    }

    void MirrorSetActive(bool isShow)
    {
        mirrorImage.SetActive(isShow);
        alertText.SetActive(isShow);
    }

    // 落ちている鏡を押すと鏡とテキストを表示
    public void OnPushMirrorImageButton()
    {
        MirrorSetActive(true);
        mirrorButton.SetActive(false);
        itembox1.SetActive(true);
        mirrorsw = true;
    }

    // ImageかTextをクリックするとこれらを非表示
    bool sw;

    public void MirrorImagePush()
    {
        sw = true;
    }

    public void MirrorTextPush()
    {
        sw = true;
    }

    void Update()
    {
        if (sw)
        {
            MirrorSetActive(false);
        }
    }

    // アイテムの選択
    public void SelectItem()
    {
        if (itembox1.activeSelf)
        {
            itembox1selected.SetActive(true);
            canManager.itembox2selected.SetActive(false);
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
        if (itembox1selected.activeSelf)
        {
            mirrorImage2.SetActive(true);
            mirrortextPanel2.SetActive(true);
        }
    }

    // バツボタンを押すと詳細非表示
    public void CloseDetail()
    {
        mirrorImage2.SetActive(false);
        mirrortextPanel2.SetActive(false);
    }
}
