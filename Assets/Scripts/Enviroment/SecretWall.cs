using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretWall : MonoBehaviour
{

    void DamageEnemy(int damageAmount)
    {
        GetComponent<Animator>().enabled = true;
    }
}
