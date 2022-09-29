using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODInteractOn : InteractableTemplate
{ 
    [Header("FMOD Settings")]
    public FMODUnity.EventReference EventRef;
    public string parameter1; // FMOD parameter 
    private StarterAssetsInputs _inputStarter; // This script was written for FPS Controller in Unity 2022
    public FMOD.Studio.EventInstance eventRef;
    public FMOD.Studio.PLAYBACK_STATE playbackState; 
    [SerializeField] GameObject eventObj; // To set a gameobject without reassigning script from the interactable (TV speaker)
    

    // Start is called before the first frame update
    void Start() // On game launch

   
    {
       
    }

    void Update()
    {
        
    }

    // Update is called once per frame
    protected override void Interact() // abastract script
    {
        eventRef = FMODUnity.RuntimeManager.CreateInstance(EventRef); // Creates event instance
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eventRef, eventObj.transform);
        eventRef.getPlaybackState(out playbackState);

        if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPED)
        {
            eventRef.start();
            eventRef.release();
        }              
       
        else if (playbackState == FMOD.Studio.PLAYBACK_STATE.PLAYING)
        {
            
        }

        else if (playbackState == FMOD.Studio.PLAYBACK_STATE.SUSTAINING)
        {
            Debug.Log("Instance sustaining");
        }

        else if (playbackState == FMOD.Studio.PLAYBACK_STATE.STARTING)
        {
            Debug.Log("Instance starting");
        }

        else if (playbackState == FMOD.Studio.PLAYBACK_STATE.STOPPING)
        {
            eventRef.start();
        }
    }
}

