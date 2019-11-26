using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class FotoScript : MonoBehaviour
{

    string screenshotName = "spelerfoto" + System.DateTime.Now.ToString("dd-MM-yyyy-HHmmss") + ".png";


    public void OnClickScreenCaptureButton()
    {
        StartCoroutine(CaptureScreen());
    }

    public IEnumerator CaptureScreen()
    {
        // Wait till the last possible moment before screen rendering to hide the UI
        yield return null;
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;


        // Wait for screen rendering to complete
        yield return new WaitForEndOfFrame();

        // Take screenshot
        Texture2D screenshot = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        screenshot.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenshot.Apply();

        // Save the screenshot to Gallery
        Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(screenshot, "PSV speler foto", screenshotName));

        // To avoid memory leaks
        Destroy(screenshot);


        // Show UI after we're done
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
    }
}