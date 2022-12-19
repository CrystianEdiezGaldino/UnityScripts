using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimyMouseChange : MonoBehaviour
{
    public Texture2D cusorAtaq;
    public Texture2D normalCusor;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void OnMouseEnter()
    {
        changeCusor(cusorAtaq);
    }
    private void OnMouseExit()
    {
        changeCusor(normalCusor);
    }
    private void changeCusor(Texture2D cusor)
    {
        Cursor.SetCursor(cusor, Vector2.zero, CursorMode.Auto);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
