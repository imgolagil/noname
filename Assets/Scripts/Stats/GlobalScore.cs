using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int scoreValue = 0;
    public int internalScore;
    public GameObject finalScore;

    // Update is called once per frame
    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "" + scoreValue;
        finalScore.GetComponent<Text>().text = "" + scoreValue;
    }
}
