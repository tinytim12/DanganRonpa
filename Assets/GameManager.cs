using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int numObjects = 6;
    public GameObject prefab;
    public float radius;

    void Start() {
        Vector3 center = transform.position;
        for (int i = 1; i < numObjects + 1; i++) {
            float ang = 360 / numObjects * i;
            Vector3 pos = RandomCircle(center, radius, ang);
            var rot = Quaternion.FromToRotation(Vector3.right, center - pos);
            Instantiate(prefab, pos, rot);
        }
    }

    Vector3 RandomCircle(Vector3 center, float radius, float ang) {
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.y = center.y;
        return pos;
    }
}