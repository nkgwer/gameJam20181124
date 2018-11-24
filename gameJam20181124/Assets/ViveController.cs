using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ViveController : MonoBehaviour {
    public bool swith = false;
    [SerializeField] SteamVR_Input_Sources inputSource;
    [SerializeField] SteamVR_Action_Boolean button;
    [SerializeField] SteamVR_Action_Vibration hapticSignal;
    bool process;
    
    // Use this for initialization
    void Start() {
        process = false;
    }

    // Update is called once per frame
    void Update() {
        swith = button.GetState(inputSource);
        if (swith && !process)
        {
             StartCoroutine(Vibrate());
            process = true;

        }
    }
    IEnumerator Vibrate()
    {
        while (true)
        {
            hapticSignal.Execute(0f, 0.5f, 300f, 1f, inputSource);
            yield return new WaitForSeconds(0.5f);
            if (!swith)
            {
                process = false;
                break;
            }
        }
        
    }
}
