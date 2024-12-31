
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    GameSceneManager gamescenemanager;

    void Start(){
        gamescenemanager = FindFirstObjectByType<GameSceneManager>();
    }
    private void OnTriggerEnter(Collider other){
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
        gamescenemanager.ReloadLevel();
    }
}
