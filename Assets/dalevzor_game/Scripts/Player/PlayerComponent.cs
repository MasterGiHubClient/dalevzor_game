using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    public PlayerEntity Player { get; private set; }

    public virtual void Init(PlayerEntity player)
    {
        Player = player;
    }
}
