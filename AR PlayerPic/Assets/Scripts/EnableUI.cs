using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class EnableUI : MonoBehaviour {

    public GameObject button;
    public GameObject Video;
    VideoPlayer vid;

	// Use this for initialization
	void Start () {
     vid = Video.gameObject.GetComponent<VideoPlayer>();
        vid.loopPointReached += Button;

    }
	
	// Update is called once per frame
	void Update () {

		
	}

    void Button(VideoPlayer vid)
    {
        button.SetActive(true);
    }
}
