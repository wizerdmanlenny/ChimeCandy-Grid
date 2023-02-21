using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateScript : MonoBehaviour
{
    [SerializeField] private GameObject finalObject; //settable object

    private Vector2 mousePos; //get mouse position

    [SerializeField] private LayerMask allTilesLayer; //layer holder

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //get mouse position
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y)); //to keep grid snap

        if(Input.GetMouseButtonDown(0)) //if left click
        {
            
            RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector2.zero, Mathf.Infinity, allTilesLayer); //what did i hit with my mouse? mousePos seems to work but not mouseRay, odd

            if (rayHit.collider == null) //if i hit nothing
            {
                Instantiate(finalObject, transform.position, Quaternion.identity); //create the settable object
            }
        }
    }
}
