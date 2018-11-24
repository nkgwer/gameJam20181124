using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSetter : MonoBehaviour {
    [SerializeField] SceneController sceneController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Score:" + sceneController.score.ToString();
	}
}
