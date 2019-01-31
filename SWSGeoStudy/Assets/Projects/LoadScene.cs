using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {

    public void LoadSceneByName()
    {
        Application.LoadLevel("Persistent");
    }
}
