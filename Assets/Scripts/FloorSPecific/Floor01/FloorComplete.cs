using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;

    private void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(ComepletedFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator ComepletedFloor()
    {
        fadeOut.SetActive(true);
        GlobalComplete.nextFloor += 1;
        PlayerPrefs.SetInt("SceneToLoad", GlobalComplete.nextFloor);
        PlayerPrefs.SetInt("LivesSaved", GlobalLife.lifeValue);
        PlayerPrefs.SetInt("ScoreSaved", GlobalScore.scoreValue);
        PlayerPrefs.SetInt("AmmoSaved", GlobalAmmo.handgunAmmo);
        

        yield return new WaitForSeconds(2);
        completePanel.SetActive(true);
        yield return new WaitForSeconds(10);
        GlobalScore.scoreValue = 0;
        GlobalComplete.enemyCount = 0;
        GlobalComplete.treasureCount = 0;
        
        SceneManager.LoadScene(GlobalComplete.nextFloor);
    }
}
