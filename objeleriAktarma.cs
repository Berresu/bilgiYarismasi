using UnityEngine;

public class objeleriAktarma : MonoBehaviour
{
    public soru[] sorular;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i<sorular.Length; i++)
        {
            Debug.Log("Soru " + (i+1));
            Debug.Log("Yazılan Metin: " + sorular[i].getMetin());

            int[] sayilar = sorular[i].getSayilar();

            for(int j = 0; j< sayilar.Length; j++)
            {
                Debug.Log("Sayı " + (j + 1) + ": " + sayilar[j]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
