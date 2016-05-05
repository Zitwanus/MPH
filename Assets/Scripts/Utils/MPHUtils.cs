using UnityEngine;
using System.Collections;

public class MPHUtils
{
    public static Vector2 ScreenToWorld(Vector2 screenPoint)
    {
        float y = Camera.main.transform.position.y - Camera.main.orthographicSize + Camera.main.orthographicSize * 2 / Screen.height * Input.mousePosition.y;
        float x = Camera.main.transform.position.x - Camera.main.orthographicSize + Camera.main.orthographicSize * 2 / Screen.width * Input.mousePosition.x;

        return new Vector2(x, y);
    }
}
