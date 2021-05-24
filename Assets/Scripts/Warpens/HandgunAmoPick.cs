using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunAmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickupSound;
    public GameObject pickUpDisplay;

    private void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        ammoPickupSound.Play();
        GlobalAmmo.handgunAmmo += 10;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "CLIP OF BULLETS";
        pickUpDisplay.SetActive(true);

    }
}
