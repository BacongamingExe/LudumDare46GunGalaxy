using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Button : MonoBehaviour
{
    public GameObject pause;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
       
        pause.SetActive (true);
        Time.timeScale += time;
    }
}
