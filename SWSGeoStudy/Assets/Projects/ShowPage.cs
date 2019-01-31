using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPage : MonoBehaviour {

	public GameObject page01;
    //public GameObject page02;
    //public GameObject item02;

    void Start ()
	{
		//page01.SetActive (false);
        //page02.SetActive(false);
    }

	public void ShowPage01()
	{
        page01.SetActive(true);
        //page02.SetActive(false);
    }

    public void HidePage01()
    {
        page01.SetActive(false);
        //page02.SetActive(false);
    }

}
