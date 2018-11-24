using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {
    Light light;
    public bool flash;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        if (flash)
        {
            StartCoroutine(Flash());
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(4.1f, 6.2f, 7.3f));
    }

    IEnumerator Flash()
    {
        while (true)
        {
            if (Time.timeSinceLevelLoad < 30)
            {
                light.intensity = 0;
                yield return new WaitForSeconds(0.5f);
                light.intensity = 1;
                yield return new WaitForSeconds(0.5f);


            }
            else if (Time.timeSinceLevelLoad < 45)
            {
                light.intensity = 0;
                yield return new WaitForSeconds(0.48f);
                light.intensity = 2;
                yield return new WaitForSeconds(0.02f);

            }
            else if (Time.timeSinceLevelLoad < 60)
            {
                yield return new WaitForSeconds(0.5f);
                light.intensity = 0;
                yield return new WaitForSeconds(0.5f);
                light.intensity = 1;

            }
            else if (Time.timeSinceLevelLoad < 71)
            {
                yield return new WaitForSeconds(0.25f);
                light.intensity = 0;
                yield return new WaitForSeconds(0.25f);
                light.intensity = 2;

            }
            else if (Time.timeSinceLevelLoad < 105)
            {
                yield return new WaitForSeconds(0.05f);
                light.intensity = 0;
                yield return new WaitForSeconds(0.05f);
                light.intensity = 3;

            }
            else if (Time.timeSinceLevelLoad < 105)
            {
                yield return new WaitForSeconds(0.5f);
                light.intensity = 0;
                yield return new WaitForSeconds(0.5f);
                light.intensity = 2;

            }
            else
            {
                light.intensity = 0;
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}
