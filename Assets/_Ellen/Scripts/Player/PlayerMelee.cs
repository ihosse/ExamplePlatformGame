using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
    [SerializeField]
    private GameObject meleeHitBox;

    public void Start() => EnableAttack(false);

    public void EnableAttack(bool value) => meleeHitBox.SetActive(value);
}
