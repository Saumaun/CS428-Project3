using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TargetAudio : MonoBehaviour, ITrackableEventHandler
{
    public TrackableBehaviour t;
    public AudioSource a;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<TrackableBehaviour>();
        if (t)
            t.RegisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status prev, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED || newStatus == TrackableBehaviour.Status.TRACKED || newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if(obj.activeSelf)
            {
                a.Play();
            }
            else
            {
                a.Stop();
            }
        }
        else
        {
            a.Stop();
        }
    }
}
