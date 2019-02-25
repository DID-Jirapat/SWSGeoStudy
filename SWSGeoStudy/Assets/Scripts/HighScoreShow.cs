using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreShow : MonoBehaviour {

    private DataController dataController;
    private PlayerProgress playerProgress;
    public Text highScoreDisplay;
    private RoundData currentRoundData;
    private QuestionData[] questionPool;
    private float timeRemaining;


    private int playerScore;

    void Start()
    {
        dataController = FindObjectOfType<DataController>();
        currentRoundData = dataController.GetCurrentRoundData();

        EndRound();
    }

    void Update()
    {
        //dataController = FindObjectOfType<DataController>();
    }


    public void EndRound()
    {
        
        highScoreDisplay.text = dataController.GetHighestPlayerScore().ToString();
    }

}
