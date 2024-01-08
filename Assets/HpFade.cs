using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPFade : MonoBehaviour
{
    // Start is called before the first frame update
    private Image barImage;
    private void Awake()
    {
        barImage = transform.Find("DamageFade").GetComponent<Image>();
    }
    private void Start()
    {
        setHealth(0.8f);
    }
    public void setHealth(float healthNormalized)
    {
        barImage.fillAmount = healthNormalized;
    }
}
