using UnityEngine;

public class Stage2Reward : MonoBehaviour
{
    [SerializeField] private float bonusMaxHealth = 2f;
    [SerializeField] private bool healToFull = true;
    private bool used = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (used) return;
        if (!other.CompareTag("Player")) return;

        Health h = other.GetComponent<Health>();
        if (h == null) return;

        h.AddMaxHealth(bonusMaxHealth, healToFull);
        used = true;

        Destroy(gameObject); // biar ga kepencet 2x
    }
}