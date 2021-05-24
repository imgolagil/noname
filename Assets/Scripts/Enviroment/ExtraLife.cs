using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    public AudioSource collectSound;

    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);        
    }

    private void OnTriggerEnter(Collider other)
    {
        GlobalLife.lifeValue += 1;
        collectSound.Play();
        gameObject.SetActive(false);
    }
}
