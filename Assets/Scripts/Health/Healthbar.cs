using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image currenthealthBar;

    // Kapasitas maksimal yang digambar di sprite strip kamu.
    // Kalau strip kamu isinya 10 hati, biarin 10.
    [SerializeField] private float spriteCapacity = 10f;

    private void Start()
    {
        UpdateBar();
    }

    private void Update()
    {
        UpdateBar();
    }

    private void UpdateBar()
    {
        // total bar menunjukkan max health (3/10 atau 5/10)
        totalhealthBar.fillAmount = playerHealth.MaxHealth / spriteCapacity;

        // current bar menunjukkan current health (misal 2/10)
        currenthealthBar.fillAmount = playerHealth.currentHealth / spriteCapacity;
    }
}
