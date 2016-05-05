using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MPHEndGameGoToScene : MPHEndGame
{
    public string _nextScene;

    public override void DoAction()
    {
        SceneManager.LoadScene(_nextScene);
    }
}
