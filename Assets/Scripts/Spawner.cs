using System;
using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {
  
  bool _canSpawn = true;
  [SerializeField] float _timerSpawn = 0f;

  [SerializeField] float _timerSpawnMin = 1f;
  [SerializeField] float _timerSpawnMax = 3f;

  [SerializeField] GameObject _prefab;

  IEnumerable Start() {
    yield return StartCoroutine(SpawnerCoroutine());
  }

  private void Update() {
    _timerSpawn += Time.deltaTime;
  }

  IEnumerator SpawnerCoroutine()
  {
    while (_timerSpawn > UnityEngine.Random.Range(_timerSpawnMin, _timerSpawnMax)) {
      var obj = Instantiate(_prefab, transform.position, transform.rotation);
      _timerSpawn = 0f;
      yield return true;
    }
  }
}