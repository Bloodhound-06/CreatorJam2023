using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Header("Keybinds")]
    public KeyCode shootKey;
    public KeyCode shootKey2;

    [Header("References")]
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject BulletStoring;

    [Header("Vector2")]
    public Vector2 BulletSpawnPosition;

    
    private void Update()
    {

        BulletSpawnPosition = new Vector3(transform.position.x, transform.position.y);
        if (Input.GetKeyDown(shootKey))
        {
            Instantiate(bullet, BulletSpawnPosition, transform.rotation, BulletStoring.transform);
        }
        else if (Input.GetKeyDown(shootKey2))
        {
            Instantiate(bullet2, new Vector2(BulletSpawnPosition.x, BulletSpawnPosition.y + 1), transform.rotation, BulletStoring.transform);
        }


    }
}
