using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MPHRestartedVelocity : MonoBehaviour
{
    public Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        MPHPuzzleManager.Instance.restartEvent += Restart;
    }

    public void Restart()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.angularVelocity = 0.0f;
    }
	
}
