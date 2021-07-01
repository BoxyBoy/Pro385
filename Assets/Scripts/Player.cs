using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    public float speed = 2;
    public GameObject shot;

    Gamepad gamepad = Gamepad.current;

    Vector2 input;

    void Start()
    {
        GetComponent<PlayerInput>().onActionTriggered += HandleAction;
    }

    private void HandleAction(InputAction.CallbackContext context)
    {
        if (context.action.name == "Fire")
        {
            OnFire();
        }
        if(context.action.name == "Move")
        {
            OnMove(context);
        }
    }

    void Update()
    {
        transform.Translate(input * speed * Time.deltaTime);

        if (gamepad == null) return;

        input = gamepad.leftStick.ReadValue();

        if(gamepad.buttonSouth.wasPressedThisFrame)
        {
            OnFire();
        }
    }

    public void OnFire()
    {
        Instantiate(shot, transform.position, Quaternion.identity);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
    }
}
