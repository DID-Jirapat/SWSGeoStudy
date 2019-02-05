using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour {

	public GameObject panel;
    bool isOn;
    void Start ()
	{
        //panel.SetActive(false);
    }

    public void ShowHidePanel()
    {
        if (isOn!=isOn)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    public void ShowPage01()
	{
        panel.SetActive(true);
    }

    public void HidePage01()
    {
        panel.SetActive(false);
    }

}
