using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioScript : MonoBehaviour
{
    [SerializeField]
    AudioSource soundEffects;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayAudioClip(AudioClip ac)
    {
        soundEffects.clip = ac;
        soundEffects.Play();
    }
}
