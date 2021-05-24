using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour
{
    public static int enemyCount = 0;
    public static int treasureCount = 0;
    public GameObject enemyDispay;
    public GameObject treashreDispay;
    public static int nextFloor = 4;


    // Update is called once per frame
    void Update()
    {
        enemyDispay.GetComponent<Text>().text = "" + enemyCount;
        treashreDispay.GetComponent<Text>().text = "" + treasureCount;
    }
}
