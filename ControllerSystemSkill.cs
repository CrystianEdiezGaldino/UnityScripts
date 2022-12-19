using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSystemSkill : MonoBehaviour
{
    public GameObject arrowPrefab;
    RaycastHit hit;
    float range =1000f;
    public Transform arrowSpawPostion;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot() {
        Vector2 screenCenter = new Vector2(Screen.width /2f , Screen.height /2f);
        Ray ray = Camera.main.ScreenPointToRay(screenCenter);
        if (Physics.Raycast(ray, out hit , range))
        {
            GameObject arrowInstantiate = GameObject.Instantiate(arrowPrefab,arrowSpawPostion.transform.position,arrowPrefab.transform.rotation) as GameObject;
            arrowInstantiate.GetComponent<Arrow>().setTarget(hit.point);
        }
            }
}
