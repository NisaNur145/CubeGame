using UnityEngine;

public class camerac : MonoBehaviour
{
    public Transform hedef;
    public float hiz=0.15f;
  Vector3 mesafe=Vector3.zero;
    private void Start()
    {
        mesafe=transform.position - hedef.position;

    }
    private void LateUpdate()
    {
        //transform.position=hedef.position+mesafe;
        Vector3 sag=new Vector3(transform.position.x,hedef.position.y+mesafe.y,hedef.position.z+mesafe.z);
        Vector3 yeniposizyon=Vector3.Lerp(transform.position,sag,hiz);
        transform.position=yeniposizyon;
    }

}
