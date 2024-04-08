using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseToTheBeat : MonoBehaviour
{
    [SerializeField] private float _pulseSize = 1.15f;
    [SerializeField] private float _returnSpeed = 5f;
    [SerializeField] private float _movementSpeed = 1f;
    [SerializeField] private float _inputTimeWindow = 0.1f; // Serialized field for adjusting time window
    private Vector3 _startSize;
    private Vector3 _startPosition;
    private bool _spacePressed;
    private float _inputTime;

    private void Start()
    {
        _startSize = transform.localScale;
        _startPosition = transform.position;
    }

    private void Update()
    {
        // Move the object from left to right
        transform.Translate(Vector3.right * _movementSpeed * Time.deltaTime);

        // If the object moves too far to the right, reset its position to the starting position
        if (transform.position.x > _startPosition.x + 10f) // Adjust the threshold as needed
        {
            transform.position = _startPosition;
        }

        // Scale down the object gradually
        transform.localScale = Vector3.Lerp(transform.localScale, _startSize, Time.deltaTime * _returnSpeed);

        // Check for spacebar input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _inputTime = Time.time;
            _spacePressed = true;
        }
    }

    public void Pulse()
    {
        // Check if spacebar was pressed and within the input time window
        if (_spacePressed && Mathf.Abs(Time.time - _inputTime) < _inputTimeWindow)
        {
            float timeDifference = Time.time - _inputTime;
            Debug.Log("Spacebar pressed on the beat! Time difference: " + timeDifference.ToString("F2") + " seconds.");
            _spacePressed = false;
        }

        // Scale up the object instantly
        transform.localScale = _startSize * _pulseSize;

        // Reset the object's position instantly
        transform.position = _startPosition;
    }
}
