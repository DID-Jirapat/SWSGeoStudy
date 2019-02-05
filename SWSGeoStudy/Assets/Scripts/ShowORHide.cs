using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowORHide : MonoBehaviour {

	public GameObject panel;
    bool isOn;
    void Start ()
	{
        //panel.SetActive(false);
    }

    public void ShowHidePanel ()
    {
        if (isOn = !isOn)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    public void ShowPanel ()
	{
        panel.SetActive(true);
    }

    public void HidePanel ()
    {
        panel.SetActive(false);
    }

}
