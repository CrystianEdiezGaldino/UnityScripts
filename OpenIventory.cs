using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenIventory : MonoBehaviour
{
    public GameObject inventory;
    public KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            inventory.SetActive(!inventory.activeSelf);
        }
    }
}
