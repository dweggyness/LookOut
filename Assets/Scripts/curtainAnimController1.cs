using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curtainAnimController1 : MonoBehaviour
{
  public GameObject animatedObject;
  public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = animatedObject.GetComponent<Animator>();
        Debug.Log(anim.gameObject);
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown("1")) {
          anim.SetTrigger("openCurtain");
        }
    }
}
