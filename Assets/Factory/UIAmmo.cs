using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAmmo : MonoBehaviour
{
    private TextMeshProUGUI text;

    [SerializeField] private Gun gun;

    private bool spawnNum;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        gun.OnAmmoChange += SetAmmoText;
    }

    void SetAmmoText()
    {
        spawnNum = !spawnNum;
        if (spawnNum) text.text = "2";
        else text.text = "1";
    }
}
