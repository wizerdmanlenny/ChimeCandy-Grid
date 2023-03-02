using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePiece : MonoBehaviour
{
    //[SerializeField] private AudioSource source;
    //[SerializeField] private AudioClip pickupClip, dropClip;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Sprite newSprite;
    private bool dragging, placed;

    private Vector2 offset, originalPos;
    private NoteSlot slot;
    public void Init(NoteSlot slot)
    {
        _renderer.sprite = slot.Renderer.sprite;
        this.slot = slot;
    }
    void Awake()
    {
        originalPos = transform.position;
    }
    // Start is called before the first frame update
    void Update()
    {
        if (placed) return;
        if (!dragging) return;

        var mousePos = GetMousePos();
        transform.position = mousePos - offset;
    }
    void OnMouseDown()
    {
        dragging = true;
        //source.PlayOneShot(pickupClip);
        offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, slot.transform.position) < 3)
        {
            transform.position = slot.transform.position;
            slot.Placed();
            _renderer.sprite = newSprite;
            placed = true;
            //source.PlayOneShot(dropClip);
        }
        else
        {
            transform.position = originalPos;
            dragging = false;
        }

    }
    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
