using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask intrMask;
    private InteractableUI interactableUI;
    private StarterAssetsInputs _inputStarter;
    private PlayerInput _playerInput;
    private FirstPersonController _firstPersonController;
    


    // Start is called before the first frame update
    void Start()
    {
        interactableUI = GetComponent<InteractableUI>();
        _inputStarter = GameObject.Find("PlayerCapsule").GetComponent<StarterAssetsInputs>();
        _playerInput = GameObject.Find("PlayerCapsule").GetComponent<PlayerInput>();
        _firstPersonController = GameObject.Find("PlayerCapsule").GetComponent<FirstPersonController>();
    }


    // Update is called once per frame
    void Update()
    {
        if (_inputStarter.interact)
        {
            print("God please make thiis work");
        }
            interactableUI.UpdateText(string.Empty);
        Ray rayInt = new Ray(transform.position, transform.forward);
        Debug.DrawRay(rayInt.origin, rayInt.direction * distance, Color.red);
        RaycastHit hitInfo;
        if (Physics.Raycast(rayInt, out hitInfo, distance, intrMask))
        {
            if (hitInfo.collider.GetComponent<InteractableTemplate>() != null)
            {

                InteractableTemplate intTemplate = hitInfo.collider.GetComponent<InteractableTemplate>();
                Debug.Log(hitInfo.collider.GetComponent<InteractableTemplate>().promptMessage);
                interactableUI.UpdateText(intTemplate.promptMessage);
                if (_inputStarter.interact)
                {
                    intTemplate.BaseInteract();
                    Debug.Log ("God please make thiis work");
                    _inputStarter.interact = false;
                }


            }    

        }
    }
}
