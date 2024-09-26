using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Rigidbody2D rigBod;
    private Vector2 moveDir;
    private Knockback knockback;

    private void Awake() {
        knockback = GetComponent<Knockback>();
        rigBod = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate() {
        if (knockback.GettingKnockedBack) { return; }
        
        rigBod.MovePosition(rigBod.position + moveDir * (moveSpeed * Time.fixedDeltaTime));
    }

    public void MoveTo(Vector2 targetPosition) {
        moveDir = targetPosition;
    }
}
