using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODampnoise : MonoBehaviour
{
    [Header("FMOD Settings")]
    public FMODUnity.EventReference EventRef;
    public string parameter1;
    FMOD.Studio.EventInstance Noise;
    [SerializeField] GameObject eventObj; 
    
    public int AmpState;
    
    void Start()
    {
        Noise = FMODUnity.RuntimeManager.CreateInstance(EventRef);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(Noise, transform);
        Noise.start();
        
    }

    // Update is called once per frame
    void Update()
    {
        Noise.setParameterByName(parameter1, AmpState);
           
    }
}
