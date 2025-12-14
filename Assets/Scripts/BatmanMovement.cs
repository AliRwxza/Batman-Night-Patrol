using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatmanMovement : MonoBehaviour
{
    public float normalSpeed = 5f;
    public float boostSpeed = 10f;
    public float rotationSpeed = 100f;
    private float currentSpeed;
    private float _speedCoefficient = 1.0f;

    public enum BatmanState { Normal, Stealth, Alert }
    public BatmanState currentState = BatmanState.Normal;

    private GameObject _lightController;

    void Start ()
    {
        _lightController = transform.Find("Lights").gameObject;
        if (_lightController == null) Debug.LogError("BatmanMovement.cs::no _lightController found.");
    }

    // Start is called before the first frame update
    void Update ()
    {
        HandleMovement();
        HandleStateChanges();
        HandleLighting();
    }

    void HandleMovement ()
    {
        // Check if Shift is held for boost
        currentSpeed = Input.GetKey(KeyCode.LeftShift) ? boostSpeed : normalSpeed;

        // Forward/Backward movement (W/S keys)
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * currentSpeed * Time.deltaTime * _speedCoefficient;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * currentSpeed * Time.deltaTime * _speedCoefficient;
        }

        // Left/Right rotation (A/D keys)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }

    void HandleStateChanges ()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Normal Mode.");
            currentState = BatmanState.Normal;
            normalSpeed = 5f;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentState = BatmanState.Stealth;
            normalSpeed = 2f; // Slower in stealth mode
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = BatmanState.Alert;
        }
    }

    void HandleLighting ()
    {
        if (currentState == BatmanState.Normal)
        {
            Debug.Log("Normal Mode.");
            _lightController.SetActive(false);
            _speedCoefficient = 1.0f;
        } else if (currentState == BatmanState.Alert)
        {
            Debug.Log("Alert Mode.");
            _lightController.SetActive(true);
            _speedCoefficient = 1.0f;
        } else
        {
            Debug.Log("Stealth Mode.");
            _speedCoefficient = 0.5f;
        }
    }
}
