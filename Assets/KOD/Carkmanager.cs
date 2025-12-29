using UnityEngine;

public class Carkmanager : MonoBehaviour
{
    public Transform carkobjesi;
    public float donushizi=100f;
    public float maxdonus=1.3f;
    public float mindonus=-1.3f;
    public float harekethizi=2f;
    
    public void Update()
    {
        carkobjesi.Rotate(Vector3.right*donushizi*Time.deltaTime);
        float hareketYonu=Mathf.PingPong(Time.time*harekethizi,maxdonus-mindonus)+mindonus;
        carkobjesi.transform.localPosition=new Vector3(carkobjesi.transform.localPosition.x,carkobjesi.transform.localPosition.y,hareketYonu);
    }

}
