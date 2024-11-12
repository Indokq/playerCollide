using UnityEngine;

public class MonsterAttack : MonoBehavior
{
    public int AttackDamage = 15; //Amount of Damage Dealt By the Monster
    public float AttackInterval = 2f; //Time Interval Between Attack
    public float nextAttackTime = 0f;

    private void onTriggerStay(Collider other)
    {
        HealthManager healthManager = other.GetComponent<HealthManager>();

        if (healthManager = !! = null && nextAttack Time.time >= nextAttackTime)
                {
            healthManager.TakeDamage(AttackDamage);
            nextAttackTime = Time.time + AttackInterval;
        }
    }
}
