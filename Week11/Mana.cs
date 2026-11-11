using UnityEngine;

public class PlayerMana : MonoBehaviour
{
  public int mana = 100;
  public TextMeshProUGUI mana text;
  public Animator animator;

  void Start()
  {
    UpdateManaText();
  }

  void update()
  {
    if (Input,GetKeyDown(KeyCode.F) && mana >=10)
    {
      mana-= 10;
      animator.SetTrigger("UseMagic");
      UpdateManaText();
    }
  }

  void UpdateManaText()
  {
    manaText.text = "Mana: " + mana;
  }
}
