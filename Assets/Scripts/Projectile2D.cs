using Unity.Mathematics;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform ShootPoint;
    [SerializeField] GameObject Target;
    [SerializeField] Rigidbody2D BulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.red, 5f);

            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null) 
            {
                Target.transform.position = new Vector2(hit.point.x, hit.point.y);
                Debug.Log("hit" + hit.collider.name);
            }
        }
    }
}
