using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCusor : MonoBehaviour
{
    public Texture2D cusor;
    public Texture2D cusorClicked;
    private void Awake()
    {
        changeCusor(cusor);
        Cursor.lockState = CursorLockMode.Confined;
    }
    private void changeCusor(Texture2D cusor)
    {
        Cursor.SetCursor(cusor,Vector2.zero,CursorMode.Auto);
    }
    private void Update()
    {
        
    }
}
