using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilManager : MonoBehaviour
{
    [SerializeField] GameObject soilText;
    [SerializeField] GameObject soilImage;
    [SerializeField] GameObject alertText;
    public GameObject backButton;
    [SerializeField] GameObject itembox6;
    public GameObject itembox6selected;

    // 取得した後詳細表示
    [SerializeField] GameObject soilImage2;
    [SerializeField] GameObject soiltextPanel2;

    // 外部スクリプト
    [SerializeField] MirrorManager mirrorManager;
    [SerializeField] CanManager canManager;
    [SerializeField] TreeBarkManager treebarkManager;
    [SerializeField] StonesManager stonesManager;
    [SerializeField] BranchesManager branchesManager;
    [SerializeField] BananaManager bananaManager;

    public bool soilsw;

    void Start()
    {
        soilText.SetActive(true);
        soilImage.SetActive(false);
        alertText.SetActive(false);
        backButton.SetActive(false);
        itembox6.SetActive(false);
        soilsw = false;
        itembox6selected.SetActive(false);

        // 取得した後詳細表示
        soilImage2.SetActive(false);
        soiltextPanel2.SetActive(false);

        // 外部スクリプト
        mirrorManager.GetComponentInParent<MirrorManager>();
        canManager.GetComponentInParent<CanManager>();
        treebarkManager.GetComponentInParent<TreeBarkManager>();
        stonesManager.GetComponentInParent<StonesManager>();
        branchesManager.GetComponentInParent<BranchesManager>();
        bananaManager.GetComponentInParent<BananaManager>();
    }


    // Textを押すと次の画面表示
    public void OnPushSoilTextButton()
    {
        soilText.SetActive(false);
        soilImage.SetActive(true);
        alertText.SetActive(true);
        itembox6.SetActive(true);
        soilsw = true;
    }

    // ImageかTextをクリックするとこれらを非表示
    bool sw;

    public void SoilImagePush()
    {
        sw = true;
    }

    public void SoilTextPush()
    {
        sw = true;
    }

    void Update()
    {
        if (sw)
        {
            soilImage.SetActive(false);
            alertText.SetActive(false);
            backButton.SetActive(true);
        }
    }

    // アイテムの選択
    public void SelectItem()
    {
        if (itembox6.activeSelf)
        {
            itembox6selected.SetActive(true);
            mirrorManager.itembox1selected.SetActive(false);
            canManager.itembox2selected.SetActive(false);
            treebarkManager.itembox3selected.SetActive(false);
            stonesManager.itembox4selected.SetActive(false);
            branchesManager.itembox5selected.SetActive(false);
            bananaManager.itembox7selected.SetActive(false);
        }
    }

    // アイテムの詳細表示
    public void OpenDetail()
    {
        if (itembox6selected.activeSelf)
        {
            soilImage2.SetActive(true);
            soiltextPanel2.SetActive(true);
        }
    }

    // バツボタンを押すと詳細非表示
    public void CloseDetail()
    {
        soilImage2.SetActive(false);
        soiltextPanel2.SetActive(false);
    }
}
