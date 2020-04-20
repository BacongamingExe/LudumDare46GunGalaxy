using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public Button TouchToPlayButton;
    public string SceneToLoad;
    public float Timing;
    public GameObject Flash;

    // Start is called before the first frame update
    void Start()
    {
        Flash.SetActive(false);
        TouchToPlayButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        StartCoroutine(Load());     
    }

    IEnumerator Load()
    {
        Flash.SetActive(true);
        yield return new WaitForSeconds(Timing);
        SceneManager.LoadScene(SceneToLoad);
    }

    // Update is called once per frame
    void Update()
    {

    }
   
}
