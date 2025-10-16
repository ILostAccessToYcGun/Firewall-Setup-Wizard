using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public Block A;
    public Block B;
    public void ProcessCollision()
    {
        int healthA = A.health;
        int healthB = B.health;
        A.TakeDamage(healthB);
        B.TakeDamage(healthA);
        Destroy(this.gameObject);
    }
}
