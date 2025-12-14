using UnityEngine;

/// <summary>
/// Controls the Bat-Signal spotlight that can be toggled
/// with B key and rotates slowly in the sky
/// </summary>
public class BatSignalController : MonoBehaviour
{
    public Light batSignalLight;
    public float rotationSpeed = 5f;
    private bool _isActive = false;
    private int _rotationFactor = 1;

    void Update ()
    {
        HandleBatSignal();
    }

    /// <summary>
    /// Toggles Bat-Signal on/off with B key and rotates when active
    /// </summary>
    void HandleBatSignal ()
    {
        // Toggle with B key
        if (Input.GetKeyDown(KeyCode.B))
        {
            _isActive = !_isActive;
            batSignalLight.enabled = _isActive;

            Debug.Log("Bat-Signal: " + (_isActive ? "ON" : "OFF"));
        }

        // Rotate slowly when active
        if (_isActive)
        {
            Debug.Log(transform.rotation.y);
            batSignalLight.transform.Rotate(0, _rotationFactor * rotationSpeed * Time.deltaTime, 0);
            if (transform.rotation.y > 0.07 || transform.rotation.y < -0.07) _rotationFactor *= -1;
        }
    }
}
