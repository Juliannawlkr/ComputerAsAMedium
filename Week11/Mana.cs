using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;

    public GameObject magicCircle;
    public Transform firePoint;

    void Start()
    {
        UpdateManaText();
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.fKey.wasPressedThisFrame && mana >= 10)
        {
            mana -= 10;

            Instantiate(magicCircle, firePoint.position, firePoint.rotation);

            UpdateManaText();
        }
    }

    void UpdateManaText()
    {
        manaText.text = "Mana: " + mana;
    }
}
