using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreShow : MonoBehaviour {

    private DataController dataController;
    private PlayerProgress playerProgress;
    public Text highScoreDisplay;


    private int playerScore;

    void Start()
    {
        dataController = FindObjectOfType<DataController>();
    }

    void Update()
    {
        EndRound();
    }


    public void EndRound()
    {
        highScoreDisplay.text = playerScore.ToString();
    }

}
