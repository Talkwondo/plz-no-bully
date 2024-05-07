using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    [SerializeField] private AudioClip _destroyClip;
    [SerializeField] private GameObject _particles;

    private Vector3 _dir;

    public void Init(Vector3 dir) {
        GetComponent<Rigidbody>().AddForce(dir);
        Invoke(nameof(DestroyBall), 0);
    }

    private void DestroyBall() {
        AudioSource.PlayClipAtPoint(_destroyClip, transform.position);
        //StartCoroutine(Coroutine());
        //Destroy(gameObject, 1);
    }

    IEnumerator Coroutine() {
        yield return new WaitForSeconds(10);
        Instantiate(gameObject, transform.position, Quaternion.identity);
    }    
    
}