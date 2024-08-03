using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellPool : ShellSingleton<ShellPool>
{
    
    private Dictionary<string, Queue<GameObject>> bulletPoolDictionary = new Dictionary<string, Queue<GameObject>>();
    

    public void CreateBulletPool(string bulletType, GameObject bulletPrefab, int initialSize)
    {
        if (!bulletPoolDictionary.ContainsKey(bulletType))
        {
            bulletPoolDictionary.Add(bulletType, new Queue<GameObject>());

            for (int i = 0; i < initialSize; i++)
            {
                GameObject bullet = Instantiate(bulletPrefab);
                bullet.GetComponent<ShellBehaviour>().SetType(bulletType);
                bullet.SetActive(false);
                bulletPoolDictionary[bulletType].Enqueue(bullet);
            }
        }
    }

    public GameObject GetBullet(string bulletType, int damageRate)
    {
        if (bulletPoolDictionary.ContainsKey(bulletType) && bulletPoolDictionary[bulletType].Count > 0)
        {
            GameObject bullet = bulletPoolDictionary[bulletType].Dequeue();
            bullet.GetComponent<ShellBehaviour>().SetDamageRate(damageRate);
            bullet.SetActive(true);
            return bullet;
        }
        else
        {
            Debug.LogWarning("Bullet pool for type " + bulletType + " does not exist or is empty.");
            return null;
        }
    }

    public void ReturnBullet(string bulletType, GameObject bullet)
    {
        bullet.SetActive(false);
        bulletPoolDictionary[bulletType].Enqueue(bullet);
    }
}
