using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class IntroController : MonoBehaviour {
    [SerializeField] ViveController viveController;
    [SerializeField] Text text;
    bool flag = true;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (viveController.swith && flag)
        {
            StartCoroutine(Intro());
            flag = false;
        }
    }
    IEnumerator Intro()
    {
        yield return new WaitForSeconds(4);
        text.text = "おい";
        yield return new WaitForSeconds(4);
        text.text = "そうだそこのバイブ持ってるお前だ";
        yield return new WaitForSeconds(4);
        text.text = "私は神だ";
        yield return new WaitForSeconds(4);
        text.text = "今から現れる者をそのバイブで癒すのじゃ";
        yield return new WaitForSeconds(4);
        text.text = "さもなくば人類の未来はない";
        yield return new WaitForSeconds(4);
        text.text = "その者の凝っている場所は赤く表示される";
        yield return new WaitForSeconds(4);
        text.text = "バイブでなるべく多くの赤い箇所をマッサージするのだ";
        yield return new WaitForSeconds(4);
        text.text = "。。。。";
        yield return new WaitForSeconds(4);
        text.text = "幸運を祈る";
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("main");
        yield return new WaitForSeconds(4);
    }
}
