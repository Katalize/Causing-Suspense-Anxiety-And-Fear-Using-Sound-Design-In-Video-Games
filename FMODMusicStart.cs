using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMODMusicStart : MonoBehaviour
{
    [Header("FMOD Settings")]
    [SerializeField] public FMODUnity.EventReference Music;
    public FMOD.Studio.EventInstance music;
    [SerializeField] private string MusicState;
    
    public int musicState;
    // Start is called before the first frame update
    void Start()
    {
          
        musicState = 0;
    }

    void Update ()
    {
        music.setParameterByName(MusicState, musicState);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MusicStart")
        {
            music = FMODUnity.RuntimeManager.CreateInstance(Music); 
            Debug.Log ("collided for music");
            music.start();
            music.setParameterByName(MusicState, musicState);
            
        }
        else if (other.gameObject.tag == "MusicStop")
        {
            music.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
        else if (other.gameObject.tag == "MusicState1")
        {
             musicState = 1;
             
        }
        else if (other.gameObject.tag == "MusicState2")
        {
             musicState = 2;
             
        }
        else if (other.gameObject.tag == "MusicState3")
        {
             musicState = 3;
             
        }
         else if (other.gameObject.tag == "MusicState4")
        {
             musicState = 4;
             
        }
         else if (other.gameObject.tag == "MusicState5")
        {
             musicState = 5;
             
        }
    }
}
