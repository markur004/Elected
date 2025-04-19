using System;
using Random = UnityEngine.Random;

namespace GameLogic
{
    public class Indexs
    {
        public float GDP = 0;
        public float publicSupport = 0;
        public float currencyValue = 0;
        public float corruption = 0;
        public float pollution = 0;
        public float budget = 0;
        public float population = 0;

        public Indexs()
        {
            GDP = Random.Range(30f, 90f);
            publicSupport = Random.Range(30f, 90f);
            currencyValue = Random.Range(30f, 90f);
            budget = Random.Range(-10f, 30f);
            population = 31f;
            corruption = Random.Range(5f, 25f);
            pollution = Random.Range(10f, 32f);
        }

        public bool IsCritical()
        {
            return GDP <= 0 || publicSupport <= 0 || currencyValue <= 0 || corruption >= 100 || budget <= -100 ||
                   population <= 5 || pollution >= 100;
        }
    }
}