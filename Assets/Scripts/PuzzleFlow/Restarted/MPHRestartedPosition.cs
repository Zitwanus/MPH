using UnityEngine;
using System.Collections;

public class MPHRestartedPosition : MonoBehaviour
{
    public Vector3 _initialPosition;

	void Start ()
    {
        _initialPosition = transform.position;
        MPHPuzzleManager.Instance.restartEvent += Restart;
	}

    public void Restart()
    {
        transform.position = _initialPosition;
    }
	
}
