using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro;

public class HealthController : MonoBehaviour
{
    public int max_can = 100;
    public int toplamPuan = 0;
    int gecerli_can = 0;

    public TextMeshProUGUI canYazisi; 
    public TextMeshProUGUI puanYazisi;

    public void Start()
    {
        gecerli_can = max_can;
        UI_Guncelle(); 
    }

    void UI_Guncelle()
    {
        if (canYazisi != null) canYazisi.text = "CAN: " + gecerli_can;
        if (puanYazisi != null) puanYazisi.text = "PUAN: " + toplamPuan;
    }

    public void healthController(int HasarMiktari)
    {
        gecerli_can -= HasarMiktari;
        if (gecerli_can <= 0)
        {
            gecerli_can = 0;
            StartCoroutine(BekleVeYenidenBaslat());
        }
        UI_Guncelle(); 
    }

    public void puanAl(int puanMiktari)
    {
        toplamPuan += puanMiktari;
        UI_Guncelle();
    }

    IEnumerator BekleVeYenidenBaslat()
    {
        Time.timeScale = 0f;
        Debug.Log("Öldün! 2 saniye bekleniyor...");
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        
        yield return new WaitForSecondsRealtime(2f);
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
