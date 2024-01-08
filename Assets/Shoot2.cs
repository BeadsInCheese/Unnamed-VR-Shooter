using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR;

public class Shoot2 : MonoBehaviour
{
    private bool reloading = false;
    private Transform barrel;
    private Transform GunModel;
    private float offset=0;
    private void Start()
    {
        barrel = this.transform.Find("barrel");
        GunModel = this.transform.Find("GunV1Textures");

        
            
    }
    public ParticleSystem explosion;
    public ParticleSystem explosion_zombie;
    public void on_shoot2() {
        
//        Debug.Log("Right");
    }
    public void reload() {
        GunModel.Rotate(offset, 0, 0);
        offset = 0;
        reloading = false;


    }
    public void on_shoot1()
    {

        if (!reloading)
        {
            reloading = true;
            GunModel.Rotate(-10, 0, 0);
            offset = 10;
            Invoke("reload", 0.3f);
            Instantiate(explosion, barrel.position, barrel.rotation);
            //      Debug.Log("Left");
            RaycastHit hit;
            if (Physics.Raycast(barrel.position, barrel.forward, out hit))
            {
                Zombie_Ai za = hit.transform.gameObject.GetComponent<Zombie_Ai>();
                if (za != null)
                {
                    Instantiate(explosion_zombie, hit.point, hit.transform.rotation);

                    za.takeDamage((int)(hit.point.y * 40));
                    //do something
                }
                //Debug.Log(hit.transform.gameObject);
            }
            else
            {
                Debug.Log("no hit");
            }
        }
        else { 
        
        }
    }
    private void Update()
    {
        if (offset > 0) {
            float change = Time.deltaTime*50;
            GunModel.Rotate(change,0,0);
            offset -= change;

        }
    }
}
