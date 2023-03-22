using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {

    private void OnMouseDown()
	{
		SceneManager.LoadScene("2"); 
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
