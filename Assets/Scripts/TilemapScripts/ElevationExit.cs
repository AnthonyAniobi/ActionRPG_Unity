using UnityEngine;
using UnityEngine.Tilemaps;

public class ElevationExit : MonoBehaviour
{
    public Collider2D[] mountains;
    public TilemapCollider2D[] boundaryColliders;
    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (Collider2D collider in mountains)
            {
                collider.enabled = true;
            }
            foreach (TilemapCollider2D collider in boundaryColliders)
            {
                collider.enabled = false;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 5;
        }    
    }
}
