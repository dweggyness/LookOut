using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockController : MonoBehaviour
{
    public GameObject myAudio;
    // Start is called before the first frame update
    void Start()
    { 
        var audio = myAudio.GetComponent<AudioSource>();
      // TV broadcast is 140 seconds long. we play the audio clip 8 secs after broadcast ends.
        audio.PlayDelayed(148);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
