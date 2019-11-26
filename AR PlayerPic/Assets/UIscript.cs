using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // needed to access the new UI classes and functions

public class UIscript : MonoBehaviour {


    public GameObject foto;
    public GameObject video;
    public GameObject scan;

    private bool scanned; 
    

    public Text videoText;
    public Text fotoText;


    // Use this for initialization
    void Start () {

        fotoText.color = Color.red; 
	}
	    
	// Update is called once per frame
	void Update ()
    {
      
    }


    public void FotoSwitch()
    {
       // buttonFoto.SetActive(true);
      //  buttonVideo.SetActive(false);
        video.SetActive(true);
        foto.SetActive(false);

        // maak foto rood & video wit
        fotoText.color = Color.white;
        videoText.color = Color.red;

    }

    public void Videoswitch()
    {
       // buttonFoto.SetActive(false);
       // buttonVideo.SetActive(true);
        video.SetActive(false);
        foto.SetActive(true);

        // maak video rood & foto wit
        videoText.color = Color.white;
        fotoText.color = Color.red;
    }

    public void scanPoster()
    {
    }
}
