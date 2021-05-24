using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;
    public AudioSource fireSound;
    public bool isFiring;
    public float fireRate = 1.5f;
    public int genHurt;
    public AudioSource[] hurtsound;
    public GameObject hurtFlash;

    Animator soldierAnimator;
    private void Start()
    {
        soldierAnimator = theSoldier.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        RaycastHit Hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }

        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire());
        } 

        if (hitTag != "Player")
        {
            soldierAnimator.Play("Idle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        soldierAnimator.Play("FirePistol", -1, 0);
        soldierAnimator.Play("FirePistol");
        fireSound.Play();
        lookingAtPlayer = true;
        GlobalHealth.healthValue -= 5;
        hurtFlash.SetActive(true);

        yield return new WaitForSeconds(0.2f);

        hurtFlash.SetActive(false);
        genHurt = Random.Range(0, 3);
        hurtsound[genHurt].Play();

        yield return new WaitForSeconds(fireRate);

        isFiring = false;
    }


}
