using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBarkManager : MonoBehaviour
{
    [SerializeField] GameObject treeBarkImage;
    [SerializeField] GameObject alertText;
    [SerializeField] GameObject treeBarkButton;
    [SerializeField] GameObject itembox3;
    public GameObject itembox3selected;

    // 取得した後詳細表示
    [SerializeField] GameObject treebarkImage2;
    [SerializeField] GameObject treebarktextPanel2;

    // 外部スクリプト
    [SerializeField] MirrorManager mirrorManager;
    [SerializeField] CanManager canManager;
    [SerializeField] StonesManager stonesManager;
    [SerializeField] BranchesManager branchesManager;
    [SerializeField] SoilManager soilManager;
    [SerializeField] BananaManager bananaManager;

    public bool treebarksw;

    void Start()
    {
        TreeBarkSetActive(false);
        treeBarkButton.SetActive(true);
        itembox3.SetActive(false);
        treebarksw = false;
        itembox3selected.SetActive(false);

        // 取得した後詳細表示
        treebarkImage2.SetActive(false);
        treebarktextPanel2.SetActive(false);

        // 外部スクリプト
        mirrorManager.GetComponentInParent<MirrorManager>();
        canManager.GetComponentInParent<CanManager>();
        stonesManager.GetComponentInParent<StonesManager>();
        branchesManager.GetComponentInParent<BranchesManager>();
        soilManager.GetComponentInParent<SoilManager>();
        bananaManager.GetComponentInParent<BananaManager>();
    }

    void TreeBarkSetActive(bool isShow)
    {
        treeBarkImage.SetActive(isShow);
        alertText.SetActive(isShow);
    }

    // 落ちている木の皮を押すと木の皮とテキストを表示
    public void OnPushTreeBarkImageButton()
    {
        TreeBarkSetActive(true);
        treeBarkButton.SetActive(false);
        itembox3.SetActive(true);
        treebarksw = true;
    }

    // ImageかTextをクリックするとこれらを非表示
    bool sw;

    public void TreeBarkImagePush()
    {
        sw = true;
    }

    public void TreeBarkTextPush()
    {
        sw = true;
    }

    void Update()
    {
        if (sw)
        {
            TreeBarkSetActive(false);
        }
    }

    // アイテムの選択
    public void SelectItem()
    {
        if (itembox3.activeSelf)
        {
            itembox3selected.SetActive(true);
            mirrorManager.itembox1selected.SetActive(false);
            canManager.itembox2selected.SetActive(false);
            stonesManager.itembox4selected.SetActive(false);
            branchesManager.itembox5selected.SetActive(false);
            soilManager.itembox6selected.SetActive(false);
            bananaManager.itembox7selected.SetActive(false);
        }
    }

    // アイテムの詳細表示
    public void OpenDetail()
    {
        if (itembox3selected.activeSelf)
        {
            treebarkImage2.SetActive(true);
            treebarktextPanel2.SetActive(true);
        }
    }

    // バツボタンを押すと詳細非表示
    public void CloseDetail()
    {
        treebarkImage2.SetActive(false);
        treebarktextPanel2.SetActive(false);
    }
}
