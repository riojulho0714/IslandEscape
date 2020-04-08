using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanelScript : MonoBehaviour
{
    //各パネルを取得
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public GameObject panel6;

    public GameObject seaPanel;


    //縦移動
    public void gotoPanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
        seaPanel.SetActive(false);

    }

    public void gotoPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
        seaPanel.SetActive(false);
    }

    public void gotoPanel3()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
        seaPanel.SetActive(false);
    }

    //横移動
    public void gotoPanel4()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(true);
        panel5.SetActive(false);
        panel6.SetActive(false);
        seaPanel.SetActive(false);
    }

    public void gotoPanel5()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(true);
        panel6.SetActive(false);
        seaPanel.SetActive(false);
    }

    public void gotoPanel6()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(true);
        seaPanel.SetActive(false);
    }

    public void OnClickSeaPanelButton()
    {
        seaPanel.SetActive(true);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);
        panel6.SetActive(false);
    }
}
