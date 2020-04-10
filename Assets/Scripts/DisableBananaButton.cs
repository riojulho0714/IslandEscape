using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使えるようにする
using UnityEngine.UI;

public class DisableBananaButton : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Click()
    {
        //ボタンを押せないようにする
        GetComponent<Button>().interactable = false;
    }
}
