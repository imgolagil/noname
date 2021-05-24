using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullHealthCollect : MonoBehaviour
{
    public AudioSource collectSound;
    public GameObject pickUpDisplay;

    private void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 100;
        gameObject.SetActive(false);
        collectSound.Play();

        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "FULL HEALTH";
        pickUpDisplay.SetActive(true);
    }
}
