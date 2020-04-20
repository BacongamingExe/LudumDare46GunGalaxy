using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Restart_Button : MonoBehaviour
{
    public Button RestartButton;
    public GameObject Player;
    public string SceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
            Restart();  
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        Destroy(Player);

        SceneManager.LoadScene(SceneToLoad);
       

    }
}
