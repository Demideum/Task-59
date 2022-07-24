using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Room : MonoBehaviour
{
    [SerializeField] private UnityEvent _movementEnter;
    [SerializeField] private UnityEvent _movementLeave;

    private void OnTriggerEnter2D(Collider2D detection)
    {
        if (detection.TryGetComponent<Thief>(out Thief thief))
        {
            _movementEnter?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D detection)
    {
        if (detection.TryGetComponent<Thief>(out Thief thief))
        {
            _movementLeave?.Invoke();
        }
    }
}
