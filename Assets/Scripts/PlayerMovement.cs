using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls keys;
    Vector2 userInnput;
    [SerializeField] float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        keys = new PlayerControls();
        keys.Enable();

        keys.Player.Leftstick.performed += ctx => userInnput = ctx.ReadValue<Vector2>();
    }

    private void Move(Vector2 vector2)
    {
        Debug.Log(vector2);
    }

    private void FixedUpdate()
    {
        transform.Translate(userInnput * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        userInnput = keys.Player.Leftstick.ReadValue<Vector2>();
    }
}
