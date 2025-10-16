using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public static CollisionManager instance;

    public GameObject collisionHandler;

    private void Awake()
    {
        instance = this;
    }
}
