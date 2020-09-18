using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Loading : MonoBehaviour
{

    VideoPlayer videoPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    
    void Update()
    {
        if (videoPlayer.frame == (long) videoPlayer.frameCount)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
