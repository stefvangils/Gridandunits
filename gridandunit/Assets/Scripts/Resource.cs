using UnityEngine;
using UnityEngine.Events;

public class Resource : MonoBehaviour
{
    public int Quantity;
    public int InitialQuantity;
    
    // Unity Events are a Unity implementation of C#-like events that work with
    // Unity's serialization system (meaning you can save them in the editor)
    // Multiple methods can 'Subscribe' to a UnityEvent, and when it is invoked
    // each of these methods are executed.
    public UnityEvent OnValueChanged = new UnityEvent(); 

    void Awake()
    {
        Quantity = InitialQuantity;
    }
    
    public void AddAmount(int value)
    {
        Quantity += value;
        updateUI();
    }

    public void RemoveAmount(int value)
    {
        Quantity -= value;
        updateUI();
    }
    

    void updateUI()
    {
        OnValueChanged.Invoke(); // Invoke the event.
    }
}
