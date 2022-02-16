using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public GameObject VideoPlayer;
    public GameObject VideoOutput;
    public bool isPlayerStarted = false;

    void Start() {

    }

    void Update()
    {
      var video = VideoPlayer.GetComponent<VideoPlayer>();
      if (video) {
        if (isPlayerStarted == false && video.isPlaying == true) {
            // When the player is started, set this information
            isPlayerStarted = true;
        }
        if (isPlayerStarted == true && video.isPlaying == false ) {
            // Wehen the player stopped playing, hide it
            video.gameObject.SetActive(false);
            VideoOutput.gameObject.SetActive(false);
        }
      }
    }
}
