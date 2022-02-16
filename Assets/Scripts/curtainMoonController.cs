using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtainMoonController : MonoBehaviour
{
  public GameObject curtain1;
  public GameObject curtain2;
  public GameObject curtain3;
  public Animator anim1;
  public Animator anim2;
  public Animator anim3;

  public bool hasCurtain1Opened = false;
  public bool hasCurtain2Opened = false;
  public bool hasCurtain3Opened = false;
  public float moonlightIntensity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim1 = curtain1.GetComponent<Animator>();
        anim2 = curtain2.GetComponent<Animator>();
        anim3 = curtain3.GetComponent<Animator>();

        moonlightIntensity = RenderSettings.ambientIntensity;
    }

    // Update is called once per frame
    void Update()
    { 
        // video lasts for 140 seconds, knocking ends at 149~ seconds. we open first window
        // at 152 seconds.
        // anim time of each curtain:
        // curtain 1 : 4s
        // curtain 2 : 4s
        // curtain 3 : 6s
        if (Time.time >= 151 && !hasCurtain1Opened) {
          hasCurtain1Opened = true;
          anim1.SetTrigger("openCurtain");
        }
        
        if (Time.time >= 157  && !hasCurtain2Opened) {
          hasCurtain2Opened = true;
          anim2.SetTrigger("openCurtain");
        }
        
        if (Time.time >= 165 && !hasCurtain3Opened) {
          hasCurtain3Opened = true;
          anim3.SetTrigger("openCurtain");
        }

        if (hasCurtain2Opened) {
          moonlightIntensity += 0.001f;
        }

       RenderSettings.ambientIntensity = moonlightIntensity;
    }
}
