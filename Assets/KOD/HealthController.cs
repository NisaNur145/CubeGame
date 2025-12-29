using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; // 1. ÖNEMLİ: Bunu eklemeyi unutma!

public class HealthController : MonoBehaviour
{
    public int max_can = 100;
    public int toplamPuan = 0;
    int gecerli_can = 0;

    // 2. UI Metinlerini buraya ekliyoruz
    public TextMeshProUGUI canYazisi; 
    public TextMeshProUGUI puanYazisi;

    public void Start()
    {
        gecerli_can = max_can;
        UI_Guncelle(); // Oyun başlarken değerleri yazdır
    }

    // 3. Ekranı güncellemek için küçük bir yardımcı fonksiyon
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
        UI_Guncelle(); // Can değişince ekranı güncelle
    }

    public void puanAl(int puanMiktari)
    {
        toplamPuan += puanMiktari;
        UI_Guncelle(); // Puan artınca ekranı güncelle
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
