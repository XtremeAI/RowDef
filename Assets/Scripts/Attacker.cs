using UnityEngine;

public class Attacker : MonoBehaviour {
  [SerializeField][Range(0f, 10f)] float _walkSpeed = 3f;

  private void Update() {
    transform.Translate(Vector2.left * Time.deltaTime * _walkSpeed);
  }
}