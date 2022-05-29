﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BGMusic.Instance.gameObject.GetComponent<AudioSource>().Pause();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    public void Unpause()
    {
        BGMusic.Instance.gameObject.GetComponent<AudioSource>().UnPause();
    }
}
