using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntercationScript : MonoBehaviour {

    public List<VideoClip> interactieClips = new List<VideoClip>();
    VideoPlayer interactie;
   

	// Use this for initialization
	void Start () {
        interactie = GetComponent<VideoPlayer>();
        interactie.clip = interactieClips[1];
        interactie.Prepare();
        // interactie.clip = interactieClips[1];
        // interactie.Prepare();
        transform.rotation = Quaternion.Euler(180, 0, 0);
    }

    public void HighFive()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
        interactie.Play();
    }


	// Update is called once per frame
	void Update () {
        if (interactie.isPrepared)
        {
            
        }
	}
}
