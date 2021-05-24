using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalLife : MonoBehaviour
{
    public GameObject lifeDisplay;
    public static int lifeValue = 3;
    public int internalLife;

    // Update is called once per frame
    void Update()
    {
        internalLife = lifeValue;
        lifeDisplay.GetComponent<Text>().text = "" + lifeValue;
    }
}
