using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

[CreateAssetMenu(fileName = "soru", menuName = "Nesnelerim/soru")]
public class soru : ScriptableObject
{
    [SerializeField] private string metin = "Buraya Metin Yazınız...";
    [SerializeField] private int[] sayilar;

    public string getMetin() {  return metin; }
    public int[] getSayilar() { return sayilar; }
    
}
