using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10;
    public float lifeTime = 1;
    public float distance = 0.5f;
    public float damage = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    // Update is called once per frame 
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up,100);
        if(hitInfo.collider != null){
            if(hitInfo.collider.CompareTag("Player")){
                hitInfo.collider.GetComponent<PlayerController>().TakeDamage(damage);
            }
        }
        /*RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit)){
            PlayerController target =  hit.transform.GetComponent<PlayerController>();
            if(target != null){
                target.TakeDamage(10f);
            }
        }*/
    }

    void DestroyProjectile(){
        Destroy(gameObject);
    }
}
