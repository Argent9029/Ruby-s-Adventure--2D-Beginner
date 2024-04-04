using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{

    [SerializeField] float speed = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //FPS Controller
        /*
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60; 
        */

    }

    // Update is called once per frame
    void Update()
    {
        //Movement Inputs Horizontal/Vertical
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Calculate movement
        Vector2 position = transform.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        transform.position = position;
    }
}