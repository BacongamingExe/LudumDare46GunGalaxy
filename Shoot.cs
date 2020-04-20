using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public Button ShootButton;

    // Start is called before the first frame update
    void Start()
    {
        ShootButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
