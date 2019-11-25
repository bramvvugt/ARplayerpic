using UnityEngine;
using Vuforia;

public class CameraSwitch : MonoBehaviour
{
    private bool on = true;

    public GameObject imageTarget;

    public void Switch()
    {
        on = !on;
        if (on)
        {
            CameraDevice.Instance.Stop();
            CameraDevice.Instance.Deinit();
            TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();

            CameraDevice.Instance.Init(CameraDevice.CameraDirection.CAMERA_BACK);
            CameraDevice.Instance.Start();
            TrackerManager.Instance.GetTracker<ObjectTracker>().Start();

        }
        else if (!on)
        {
            imageTarget.transform.rotation = Quaternion.Euler(0, 0, 180);
            CameraDevice.Instance.Stop();
            CameraDevice.Instance.Deinit();

            TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
            CameraDevice.Instance.Init(CameraDevice.CameraDirection.CAMERA_FRONT);

            CameraDevice.Instance.Start();
            TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
        }
    }
}