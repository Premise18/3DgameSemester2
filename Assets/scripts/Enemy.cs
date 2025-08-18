using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private int HP = 100;
    public Slider healthBar;
    public Animator Animator;


    private void Update()
    {
        healthBar.value = HP;
    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            Animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
        }
        else 
        {
            Animator.SetTrigger("damage");
        }

    }

}
