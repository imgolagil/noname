  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKey : MonoBehaviour
{
    public GameObject keyUI;
    public GameObject lockedTrigger;

    private void OnTriggerEnter(Collider other)
    {
        keyUI.SetActive(true);
        lockedTrigger.SetActive(true);
        gameObject.SetActive(false);
    }
}
