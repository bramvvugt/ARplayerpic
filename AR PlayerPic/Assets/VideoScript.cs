using System;
using System.Collections;
using System.IO;
using GetSocialSdk.Capture.Scripts;
using GetSocialSdk.Capture.Scripts.Internal.Gif;
using GetSocialSdk.Capture.Scripts.Internal.Recorder;
using GetSocialSdk.Scripts.Internal.Util;
using UnityEngine;

using ThreadPriority = System.Threading.ThreadPriority;

public class VideoScript : MonoBehaviour {

    public GetSocialCapture capture;

    void Awake()
    {
 
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void recordVideo()
    {
        capture.StartCapture();
    }

    public void stopRecod ()
    {

    }
}
