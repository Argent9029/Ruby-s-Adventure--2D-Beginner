using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 3f;

    public int maxHealth = 5;

    int currentHealth;
    public int health { get { return maxHealth; } }

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;


    // Start is called before the first frame update
    void Start()
    {
        //FPS Controller
        /*
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60; 
        */

        rigidbody2d = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
        currentHealth = 1;

    }

    // Update is called once per frame
    void Update()
    {
        //Movement Inputs Horizontal/Vertical
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

    }

    void FixedUpdate()
    {
        //Calculate movement
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    public void ChangeHealth(int amount)
    {

        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);

    }

}
