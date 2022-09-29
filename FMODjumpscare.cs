using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODjumpscare : MonoBehaviour
{
    [SerializeField] GameObject eventObject;
    public FMODUnity.EventReference EventRef;
    FMOD.Studio.EventInstance EventInst;
    bool Played;

    // Start is called before the first frame update
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player" & Played == false)
        {
        EventInst = FMODUnity.RuntimeManager.CreateInstance(EventRef);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(EventInst, eventObject.transform);
        EventInst.start();
        EventInst.release();
        Played = true;
        }
        
        
    }
}