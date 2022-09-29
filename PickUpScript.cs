using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    [Header("FMOD Settings")] 
    public FMODUnity.EventReference EventRef;
    [SerializeField] private string ParameterName;
    public int ParameterValue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FMODPlay();
            Destroy(gameObject);

        }
    }

    void FMODPlay()
    {
        FMOD.Studio.EventInstance PickUp = FMODUnity.RuntimeManager.CreateInstance(EventRef);
        
        PickUp.setParameterByName(ParameterName, ParameterValue);
        PickUp.start();
        PickUp.release();
    }

}
