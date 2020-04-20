using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playercontroller : MonoBehaviour
{

    public float movespeed;
    public float jumpforce;
    public float ShotWait;
    public Button JumpButton;
    public GameObject ShotLight;
    public GameObject DeathCubes;
    public GameObject Player;
    public GameObject Score;
    public GameObject DeathUI;

    private Rigidbody2D myRigidbody;
   
    private Collider2D myCollider;


    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        JumpButton.onClick.AddListener(TaskOnClick);
        myCollider = GetComponent<Collider2D>();

        ShotLight.SetActive(false);
        DeathCubes.SetActive(false);
        Player.SetActive(true);
        DeathUI.SetActive(false);
        Score.SetActive(true);
    }

    void TaskOnClick()
    {
        StartCoroutine(FireLight());
        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpforce);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.identity, movespeed * Time.deltaTime);      
    }

    IEnumerator FireLight()
    {
        ShotLight.SetActive(true);

        yield return new WaitForSeconds(ShotWait);

        ShotLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(movespeed, myRigidbody.velocity.y);
        
    }

    void GameOver()
    {
        Player.SetActive(false);
        DeathCubes.SetActive(true);
        DeathUI.SetActive(true);
        Score.SetActive(false);

    }
}