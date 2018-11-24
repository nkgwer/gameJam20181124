using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark : MonoBehaviour {
    [SerializeField] Vector3 minScale;
    float scaleFactor;
    public SceneController sceneController;
    // Use this for initialization
    void Start() {
        sceneController = GameObject.FindGameObjectsWithTag("SceneController")[0].gameObject.GetComponent<SceneController>();
    }
    private void OnEnable()
    {
        StartCoroutine(Animate());
    }
    // Update is called once per frame
    void Update() {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Vibe")
        {
            gameObject.SetActive(false);
            sceneController.flag = true;
        }
    }

    IEnumerator Animate()
    {
        while (true)
        {
            scaleFactor = 1f;
            while (scaleFactor < 2)
            {
                transform.localScale = minScale * scaleFactor;
                scaleFactor += 0.01f;
                yield return null;
            }
           
        }
    }
}
