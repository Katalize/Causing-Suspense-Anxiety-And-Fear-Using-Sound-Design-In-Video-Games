using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableTemplate : MonoBehaviour
{
    public string promptMessage;

    // function will be called from the player script
    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
        // template function
    }

}

    
