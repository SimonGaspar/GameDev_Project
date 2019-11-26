using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{

    public int damage = 200;                  
    public float radius = 1f;

    private BoxCollider TriggerMine;
    private SphereCollider TriggerExplosion;              
    private ParticleSystem HitParticles;
    private bool Active = false;
    private AudioSource AudioData;
    private Animator animator;

    private void Awake()
    {

        TriggerMine = GetComponent<BoxCollider>();
        TriggerExplosion = GetComponent<SphereCollider>();
        HitParticles = GetComponentInChildren<ParticleSystem>();
        Active = true; 
        AudioData = GetComponent<AudioSource>();
        animator= GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player" && Active)
        {
            Active = false;
            animator.SetBool("Active", Active);
            Explode(transform.position,radius);
        }
    }

    private void Explode(Vector3 center, float radius)
    {
        Collider[] hitColliders = Physics.OverlapSphere(center, radius);
        AnimateExplode();
        HitParticles.transform.position = transform.position;
        var shape = HitParticles.shape;
        shape.radius = radius;
        HitParticles.Play();
        AudioData.Play(0);
        foreach (Collider hit in hitColliders) {
            var enemyHealth = hit.gameObject.GetComponent<CompleteProject.EnemyHealth>();
            // If the EnemyHealth component exist...
            if (enemyHealth != null)
            {
                // ... the enemy should take damage.
                enemyHealth.TakeDamage(damage, hit.ClosestPoint(center));
            }
        }

        Destroy(gameObject,0.4f);
    }

    private void AnimateExplode()
        {
            Animation anim = GetComponent<Animation>();
            AnimationCurve curve;

            // create a new AnimationClip
            AnimationClip clip = new AnimationClip();
            clip.legacy = true;

            // create a curve to move the GameObject and assign to the clip
            Keyframe[] keys;
            keys = new Keyframe[2];
            keys[0] = new Keyframe(0.0f, transform.position.y);
            keys[1] = new Keyframe(1.0f, transform.position.y-0.1f);
            curve = new AnimationCurve(keys);
            clip.SetCurve("", typeof(Transform), "localPosition.y", curve);
        
            // now animate the GameObject
            anim.AddClip(clip, clip.name);
            anim.Play(clip.name);
    }
}
