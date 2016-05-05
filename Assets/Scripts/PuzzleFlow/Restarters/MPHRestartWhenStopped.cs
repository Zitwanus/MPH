using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MPHRestartWhenStopped : MonoBehaviour
{
    public Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (_rigidbody.velocity == Vector2.zero)
        {
            MPHPuzzleManager.Instance.Restart();
        }
    }
}
