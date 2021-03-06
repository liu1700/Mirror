using UnityEngine;
using Mirror;

namespace MirrorTest
{
    class MirrorTestPlayer : NetworkBehaviour
    {
        [SyncVar(hook="OnChangeHealth")]
        int health;

        class MySyncVar : ScriptableObject
        {
            int abc = 123;
        }
        [SyncVar]
        MySyncVar invalidVar = new MySyncVar();

        public void TakeDamage(int amount)
        {
            if (!isServer)
                return;

            health -= amount;
        }

        void OnChangeHealth(int health)
        {
            // do things with your health bar
        }
    }
}
