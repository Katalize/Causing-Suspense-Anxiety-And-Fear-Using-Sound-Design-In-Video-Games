using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODInteractGuitarOn : InteractableTemplate
{ 
    [Header("FMOD Settings")]
    public FMODUnity.EventReference EventRef;
    public string parameter1; // FMOD parameter 
    private StarterAssetsInputs _inputStarter; // This script was written for FPS Controller in Unity 2022
    public FMOD.Studio.EventInstance eventRef;
    public FMOD.Studio.PLAYBACK_STATE playbackState; 
    [SerializeField] GameObject eventObj; // To set a gameobject without reassigning script from the interactable (TV speaker)
    public GameObject Amp;
    public FMODampnoise fMODampnoise;

    // Start is called before the first frame update
    void Start() // On game launch

    {
        Amp = GameObject.Find("amp");
        Amp.GetComponent<FMODampnoise>();
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
            eventRef.setParameterByName(parameter1, fMODampnoise.AmpState);
            eventRef.start();
            eventRef.release();
        }              
    }
}
