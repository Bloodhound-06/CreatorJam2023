using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Header("Keybinds")]
    public KeyCode shootKey;

    [Header("References")]
    public GameObject bullet;
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
    }
}
