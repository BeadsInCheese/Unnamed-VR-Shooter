using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Ai : MonoBehaviour
{
    int hp = 40;
    int speed = 3;
    public HPBar hpvisual;
   public GameObject player;
    private bool alive = true;
    Animator ant;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("XR Origin");
        ant = GetComponentInChildren<Animator>();
    }
    private void Die() {
        if (alive)
        {
            GetComponent<CapsuleCollider>().enabled = false;
            Destroy(this.transform.gameObject, 10);
            ManageGame.Instance.score += 100;
            ManageGame.Instance.zombiesLeft -= 1;
            alive = false;
        }
    }
    // Update is called once per frame
    public void takeDamage(int damage) {
        ant.SetTrigger("Damage");
            hp -= damage;
    
    }
    void Update()
    {
        hpvisual.setHealth(hp/40.0f);
        ant.SetInteger("HP", hp);
        transform.LookAt(new Vector3(player.transform.position.x,transform.position.y, player.transform.position.z));
        Vector3 target = (player.transform.position - transform.position);
        target.y = 0;
        if (target.magnitude > 1 && hp>0)
        {
            transform.position += Time.deltaTime * ((target).normalized)*speed;
        }
        if (hp <= 0) {
            Die();
        }
        if (target.magnitude < 1)
        {
            ManageGame.Instance.plng = false;
            ManageGame.Instance.scoreEntered = false;
        }
        if (!ManageGame.Instance.plng) { Destroy(this.transform.gameObject); }
    }
}
