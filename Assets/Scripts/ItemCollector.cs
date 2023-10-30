using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{   
    private float diamonds = 0f;
    public AudioClip impact;

    [SerializeField] private Text diamondsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Diamond"))
        {   
            AudioSource.PlayClipAtPoint(impact, transform.position);
            Destroy(collision.gameObject);
            diamonds++;
            diamondsText.text = "Diamonds: " + diamonds;
        }
    }
}
