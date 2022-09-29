using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODAnimataion : MonoBehaviour
{
    public FMODUnity.EventReference EventRef;
    [SerializeField] private string ParameterName;
    public int ParameterValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void PlayOneShotAnim()
    {
        FMOD.Studio.EventInstance PickUp = FMODUnity.RuntimeManager.CreateInstance(EventRef);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(PickUp, transform);
        PickUp.setParameterByName(ParameterName, ParameterValue);
        PickUp.start();
        PickUp.release();
    }
}
