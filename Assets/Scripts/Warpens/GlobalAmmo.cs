using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int handgunAmmo;
    public GameObject ammoDisplay;

    private Text text;
    private void Start()
    {
        text = ammoDisplay.GetComponent<Text>();  
    }

    void Update()
    {
        text.text = handgunAmmo.ToString();
    }
}
