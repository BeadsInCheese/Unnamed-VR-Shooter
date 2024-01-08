using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    // Start is called before the first frame update
    private const float DAMAGE_HEALTH_TIMER_MAX = 1f;
    private Image barImage;
    private Image damagedbarImage;
    private Color damagedColor;
    private float damagedHealthFade;
    private void Awake()
    {
        barImage = transform.Find("Background").GetComponent<Image>();
        damagedbarImage = transform.Find("DamageFade").GetComponent<Image>();
        damagedColor = damagedbarImage.color;
        damagedColor.a = 0f;
    }
    private void Start()
    {
        //setHealth(0.8f);
    }
    private void Update()
    {
        if (damagedColor.a > 0){
            damagedHealthFade -= Time.deltaTime;
            if (damagedHealthFade <= 0) {
                damagedColor.a -= 1f * Time.deltaTime;
                damagedbarImage.color = damagedColor;
            }
        }
    }
    public void setHealth(float healthNormalized) {
        
        if (healthNormalized != barImage.fillAmount)
        {
            if (damagedColor.a <= 0)
            {
                damagedbarImage.fillAmount = barImage.fillAmount;
            }
            damagedColor.a = 1f;
            damagedbarImage.color = damagedColor;
            damagedHealthFade = DAMAGE_HEALTH_TIMER_MAX;
        }
        barImage.fillAmount = healthNormalized;
        damagedbarImage.fillAmount = Mathf.Lerp(damagedbarImage.fillAmount,healthNormalized,0.01f);
    }
}
