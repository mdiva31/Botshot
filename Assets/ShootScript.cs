using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public GameObject dor;
    public ParticleSystem muzzleFlash;
    public Text ScoreText;
    public int Score;
    public string sceneName;
    public string bottleName;
    public string bottleName2;
    public string bottleName3;

    public void Shoot() {
        muzzleFlash.Play();
        Instantiate(dor);
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)){
            if (hit.transform.name == bottleName || hit.transform.name == bottleName2 || hit.transform.name == bottleName3){
                Destroy(hit.transform.gameObject);

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                MinusScore();
                
            }
        }
    }
    void MinusScore(){
        Score--;
        ScoreText.text = Score.ToString();
    }
    
    void Update(){
        if(Score <=0){
            YouWin();
        }
    }
    void YouWin()
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
