using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShellBehaviour : MonoBehaviour
{
    int damageRate;
    public float shellSpeed;
    public ParticleSystem ShellCollision;
    public ParticleSystem ShellHitGround;
    Rigidbody rb;
    public bool isExplosive;
    public float explosionForce;
    public float explosionRadius;
    Vector3 firstPosition;
    //float maxDistance = 800.0f;
    string type;
    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    firstPosition = gameObject.transform.position;
    //}
    void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        firstPosition = gameObject.transform.position;
    }
    public void SetType(string type) 
    {
        this.type = type;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        //MainAudioManager.Instance.transform.position = transform.position;
        if (isExplosive)
        {
            Vector3 explosionPosition = transform.position;
 
            //MainAudioManager.Instance.PlayExplosionSound();
            Collider[] colliders = Physics.OverlapSphere(explosionPosition, explosionRadius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb1 = hit.GetComponent<Rigidbody>();
                if (rb1 != null)
                {
                    rb1.AddExplosionForce(explosionForce * 100, explosionPosition, explosionRadius * 10000);
                }
            }
        }
        else 
        {
            
            //MainAudioManager.Instance.PlayHitSound();
        }
        if (ShellCollision != null)
        {
            Instantiate(ShellCollision, transform.position, Quaternion.identity);
        }

        if (collision.gameObject.GetComponent<HealthManager>() != null) 
        {
            collision.gameObject.GetComponent<HealthManager>().TakeDamage(damageRate); 
        }
        
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        ShellPool.Instance.ReturnBullet(type, gameObject);
        
    }
    public void SetDamageRate(int damageRate) 
    {
        this.damageRate = damageRate;
    }
    
    //private void DestroyAnyway()
    //{
    //    if (gameObject != null && Vector3.Distance(firstPosition, gameObject.transform.position) > maxDistance)
    //    {
    //        rb.velocity = Vector3.zero;
    //        rb.angularVelocity = Vector3.zero;
    //        ShellPool.Instance.ReturnBullet(type, gameObject);
    //    }
    //}
}
