using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;//color variables
    [SerializeField] private SpriteRenderer _renderer;//set the color of tile sprite
    [SerializeField] private GameObject highlight;

    public void Init(bool isOffset)//for making checkard pattern
    {
        _renderer.color = isOffset ? offsetColor : baseColor;
    }

    void OnMouseEnter()//if mouse hovers over tile,highlight tile
    {
        highlight.SetActive(true);
    }

    void OnMouseExit()
    {
        highlight.SetActive(false);
    }
}
