using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brama : MonoBehaviour
{

    bool a;

    private void OnMouseDown()
    {
        a = !a;
    }
    void Update()
    {
        if (a)
        {
            if ( transform.position.y > 118)
            {
                transform.Translate(0, -0.1f, 0);
            }
        }
    }
    private void OnMouseOver(){
        Texture2D cursor = Resources.Load("strzalka") as Texture2D;
        Cursor.SetCursor(cursor, new Vector2(32, 32), CursorMode.ForceSoftware);
        Cursor.visible = true;
    }

    private void OnMouseExit(){
        Cursor.SetCursor(null, new Vector2(32, 32), CursorMode.ForceSoftware);
        Cursor.visible = false;
    }
}
