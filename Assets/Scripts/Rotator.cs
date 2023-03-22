using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 direction = Vector3.forward;
    [SerializeField] private float delay;
    [SerializeField] private float rotationSpeed;

    private bool _canRotate;
    
    private void Awake()
    {
        StartCoroutine(Delay());
    }

    private IEnumerator Delay()
    {
        _canRotate = false;
        yield return new WaitForSeconds(delay);
        _canRotate = true;
    }

    private void Update()
    {
        if (!_canRotate)
        {
            return;
        }
        
        transform.Rotate(direction * (rotationSpeed * Time.deltaTime));
    }
}
