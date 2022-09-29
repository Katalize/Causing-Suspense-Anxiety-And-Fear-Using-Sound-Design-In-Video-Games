using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetecor : MonoBehaviour
{
    public int areaId = 0;
    private DebugUI debugUI;

    private void Start()
    {
        debugUI = GameObject.Find("Canvas").GetComponent<DebugUI>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "TP0")
        {
            areaId = 0;
        }
        else if (collision.gameObject.tag == "TP1")
        {
            areaId = 1;
        }
        else if (collision.gameObject.tag == "TP2")
        {
            areaId = 2;
        }
        else if (collision.gameObject.tag == "TP3")
        {
            areaId = 3;
        }
        else if (collision.gameObject.tag == "TP4")
        {
            areaId = 4;
        }
        else if (collision.gameObject.tag == "TP5")
        {
            areaId = 5;
        }
        Debug.Log ("Current area " + areaId);
        debugUI.AreaCode = areaId;
    }

}
