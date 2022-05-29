using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootScriptTimeAttack : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public GameObject dor;
    public ParticleSystem muzzleFlash;
    public Text ScoreText;
    public string bottleName;
    public void Shoot() {
        muzzleFlash.Play();
        Instantiate(dor);
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)){
            if (hit.transform.name == bottleName){
                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                AddScore();
                
            }
        }
    }

    public void AddScore()
    {
        Scoring.totalScore += 10;
        ScoreText.text = Scoring.totalScore.ToString();
    }

    public void GetScore()
    {
        int receivedScore = Scoring.totalScore;
        ScoreText.text = receivedScore.ToString();
        ResetScore();
    }

    public void ResetScore()
    {
        Scoring.totalScore = 0;
    }

}