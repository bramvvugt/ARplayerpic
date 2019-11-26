using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Recorder;

public class VideoScript : MonoBehaviour {


    public RecordManager recordManager;


    public void startVideo()
    {
        recordManager.StartRecord();
    }

    public void saveVideo()
    {
        recordManager.StopRecord();
    }
}
