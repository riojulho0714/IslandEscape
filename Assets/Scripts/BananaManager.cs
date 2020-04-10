using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaManager : MonoBehaviour
{
	[SerializeField] GameObject bananaImage;
	[SerializeField] GameObject alertText;
	public GameObject bananaPanel;
	public GameObject panel6;
	public GameObject itemBox;
	

	void Start()
	{
		BananaSetActive(false);
	}

	void BananaSetActive(bool isShow)
	{
		bananaImage.SetActive(isShow);
		alertText.SetActive(isShow);
	}

	// バナナを押すと缶詰とテキストを表示
	public void OnPushBananaImageButton()
	{
		BananaSetActive(true);
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
}
