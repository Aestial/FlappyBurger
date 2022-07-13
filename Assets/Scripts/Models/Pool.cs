using UnityEngine;

public class Pool
{
    private int currentIndex = 0;
    private GameObject[] pool;
    private GameObject prefab;
    private int size;
    private Transform parent;
    
    public Pool(GameObject prefab, int size, Transform parent)
    {
        this.prefab = prefab;
        this.size = size;
        this.parent = parent;
        pool = new GameObject[size];
        for (int i = 0; i < size; i++)
        {
            pool[i] = GameObject.Instantiate(prefab, parent);
            pool[i].SetActive(false);
        }
    }
    public GameObject GetCurrent()
    {
        return pool[currentIndex];
    }
    public GameObject GetNext()
    {
        currentIndex = (currentIndex + 1) % size;
        GameObject next = pool[currentIndex];
        return next;
    }
    public void Reset()
    {
        currentIndex = 0;
    }
    public void DestroyAll()
    {
        for (int i = 0; i < size; i++)
        {
            GameObject.Destroy(pool[i]);
        }
    }
}