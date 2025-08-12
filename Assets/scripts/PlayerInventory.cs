using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfTomatoes { get; private set; }

    public UnityEvent<PlayerInventory> OnTomatoCollected;

    public void TomatoCollected()
    {
        NumberOfTomatoes++;
        OnTomatoCollected.Invoke(this);
    }
}
