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

    private bool isRoundActive = false;
    private int playerScore;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();

    void Start()
    {
        dataController = FindObjectOfType<DataController>();                                // Store a reference to the DataController so we can request the data we need for this round
                       // Ask the DataController for the data for the current round. At the moment, we only have one round - but we could extend this                                     // Take a copy of the questions so we could shuffle the pool or drop questions from it without affecting the original RoundData object
        playerScore = 0;

        isRoundActive = true;
    }

    void Update()
    {
        EndRound();
    }


    public void EndRound()
    {
        highScoreDisplay.text = dataController.GetHighestPlayerScore().ToString();
    }
}
