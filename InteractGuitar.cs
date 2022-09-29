using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractGuitar : InteractableTemplate
{ 
    public FMODampnoise fMODampnoise;

    [Header("FMOD Settings")]
    public FMODUnity.EventReference EventRef;
    
    [SerializeField] GameObject eventObj;
     public void Awake()
     {
        
     }
    protected override void Interact() // abastract script
    {

        if (fMODampnoise.AmpState == 0)
        {
            FMODUnity.RuntimeManager.PlayOneShot(EventRef, eventObj.transform.position);
            fMODampnoise.AmpState = 1;
            Debug.Log ("Amp is set to Lead");
        }
        else if (fMODampnoise.AmpState == 1)
        {
            FMODUnity.RuntimeManager.PlayOneShot(EventRef, eventObj.transform.position);
            fMODampnoise.AmpState = 0;
            Debug.Log ("Amp is set to Clean");
        }
        
    }
}
