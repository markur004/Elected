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
            GDP = Random.Range(2f, 8f);
            publicSupport = Random.Range(30f, 90f);//silder value
            currencyValue = Random.Range(30f, 90f);//text value
            budget = Random.Range(-60f, 320f);
            population = 31f;
            corruption = Random.Range(5f, 25f);//silder value
            pollution = Random.Range(10f, 32f);//text value
        }

        public void ApplayChanages(Decision decision)
        {
            GDP += decision.GDPChange;
            publicSupport += decision.publicSupportChange;
            currencyValue += decision.currencyValueChange;
            corruption += decision.corruptionChange;
            population += decision.populationChange;
            budget += decision.budgetChange;
            pollution += decision.pollutionChange;
        }

        public bool IsCritical()
        {
            return GDP <= 0 || publicSupport <= 0 || currencyValue <= 0 || corruption >= 100 || budget <= -100 ||
                   population <= 5 || pollution >= 100;
        }
    }
}