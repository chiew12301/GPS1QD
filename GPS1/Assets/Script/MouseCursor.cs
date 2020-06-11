using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D normalCursor;
    public Texture2D Cursor1;

    void Start()
    {
        setToDefaultCursor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setToDefaultCursor()
    {
        Cursor.SetCursor(normalCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void setToCursor1()
    {
        Cursor.SetCursor(Cursor1, Vector2.zero, CursorMode.ForceSoftware);
    }

}
