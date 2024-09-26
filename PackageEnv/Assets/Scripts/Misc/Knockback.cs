using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public bool GettingKnockedBack { get; private set;}

    [SerializeField] private float knockBackTime = .15f;
    private Rigidbody2D rigBod;

    private void Awake() {
        rigBod = GetComponent<Rigidbody2D>();
    }

    public void GetKnockedBack(Transform damageSource, float knockBackThrust) {
        GettingKnockedBack = true;
        // Difference is Force of Knockback
        Vector2 difference = (transform.position - damageSource.position).normalized * knockBackThrust * rigBod.mass;
        rigBod.AddForce(difference, ForceMode2D.Impulse);
        StartCoroutine(KnockRoutine());
    }

    private IEnumerator KnockRoutine() {
        yield return new WaitForSeconds(knockBackTime);
        rigBod.velocity = Vector2.zero;
        GettingKnockedBack = false;
    }
}
