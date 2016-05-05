using UnityEngine;
using System.Collections;

public class MPHTimerObjective : MPHPuzzleObjective
{
    public float _timeLeft;
    public float _maxTime;

    void Start()
    {
        _timeLeft = _maxTime;
    }

    void Update()
    {
        _timeLeft -= Time.deltaTime;
        if (_timeLeft < 0)
        {
            MPHPuzzleManager.Instance.ObjectiveFilled(this);
            _timeLeft = _maxTime;
        }
    }
}
