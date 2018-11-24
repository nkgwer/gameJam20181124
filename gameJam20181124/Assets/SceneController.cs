using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
    public List<Mark> marks = new List<Mark>();
    [SerializeField] VoiceController voiceController;
    public bool flag;
    public int score = 0;
    [SerializeField] GameObject[] deleteAtEnd;
	// Use this for initialization
	void Start () {
        var l = GameObject.FindGameObjectsWithTag("Mark");
        for(int i = 0; i < l.Length; i++)
        {
            marks.Add(l[i].GetComponent<Mark>());
            l[i].SetActive(false);
        }
        marks[Random.Range(0, marks.Count)].gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            voiceController.Play();
            marks[Random.Range(0, marks.Count)].gameObject.SetActive(true);
            score++;
            flag = false;
        }
        if(Time.timeSinceLevelLoad > 105)
        {
            for(int i=0;i<deleteAtEnd.Length; i++)
            {
                deleteAtEnd[i].SetActive(false);
            }
        }
    }
}
