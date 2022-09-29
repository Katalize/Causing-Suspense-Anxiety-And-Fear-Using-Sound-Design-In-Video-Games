using StarterAssets;
using System.Collections;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] GameObject TPO0;
    [SerializeField] GameObject TPO1;
    [SerializeField] GameObject TPO2;
    [SerializeField] GameObject TPO3;
    [SerializeField] GameObject TPO4;
    [SerializeField] GameObject TPO5;

    FirstPersonController playerController;

    Vector3 teleLoc0;
    Vector3 teleLoc1;
    Vector3 teleLoc2;
    Vector3 teleLoc3;
    Vector3 teleLoc4;
    Vector3 teleLoc5;


    void Start()
    {
        playerController = gameObject.GetComponent<FirstPersonController>();

        teleLoc0 = TPO0.transform.position;
        teleLoc1 = TPO1.transform.position;
        teleLoc2 = TPO2.transform.position;
        teleLoc3 = TPO3.transform.position;
        teleLoc4 = TPO4.transform.position;
        teleLoc5 = TPO5.transform.position;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TP0")
        {
            StartCoroutine(DelayTeleport(teleLoc0));
        }

        else if (other.gameObject.tag == "TP1")
        {
            StartCoroutine(DelayTeleport(teleLoc1));
            Destroy(GameObject.Find("Teleporter1"));
        }

        else if (other.gameObject.tag == "TP2")
        {
            StartCoroutine(DelayTeleport(teleLoc2));
            Destroy(GameObject.Find("Teleporter2"));
        }

        else if (other.gameObject.tag == "TP3")
        {
            StartCoroutine(DelayTeleport(teleLoc3));
            Destroy(GameObject.Find("Teleporter3"));
        }

        else if (other.gameObject.tag == "TP4")
        {
            StartCoroutine(DelayTeleport(teleLoc4));
            Destroy(GameObject.Find("Teleporter4"));
        }

        else if (other.gameObject.tag == "TP5")
        {
            StartCoroutine(DelayTeleport(teleLoc5));
            Destroy(GameObject.Find("Teleporter5"));
        }
        
    }

    void TeleportStart(Vector3 tpLocator)
    {
        gameObject.transform.position = tpLocator;
        Debug.Log(tpLocator + "tp script done");
    }

    IEnumerator DelayTeleport(Vector3 tpLocator)
    {
        playerController.disable = true;
        print("tp controlls disabled");
        TeleportStart(tpLocator);
        print("tp Triggered");
        print(" tp skipped frame");
        yield return new WaitForSeconds(0.1f);
        playerController.disable = false;
    }
}

