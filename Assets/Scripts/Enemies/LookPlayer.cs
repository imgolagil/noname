using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public Transform thePlayer;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(thePlayer);    
    }
}
