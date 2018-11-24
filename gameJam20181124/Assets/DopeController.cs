using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DopeController : MonoBehaviour {
    public float factor = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(1, 2, 3) *factor);
	}
}
