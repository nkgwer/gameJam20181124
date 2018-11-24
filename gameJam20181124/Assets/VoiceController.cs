using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceController : MonoBehaviour {
    [SerializeField] AudioSource[] audioSources; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        audioSources[Random.Range(0, audioSources.Length)].Play();
    }
}
