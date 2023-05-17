using UnityEngine;

public class AIParameterModifier : MonoBehaviour
{
    [SerializeField] private float hPSpeedDecreaser;
    public DataStorage dataStorage;
    private void Start()
    {

    }
    public float ManagerHP()
    {
        HP -= Time.deltaTime;
        return HP;
    }
    public float ManagerEnergy()
    {
        Energy -= Time.deltaTime;
        //Energy -= (Hunger + Thirst) * 0.0005f;
        return Energy;
    }
    public float ManagerHunger()
    {
        Hunger -= Time.deltaTime;
        return Hunger;
    }
    public float ManagerThirst()
    {
        Thirst -= Time.deltaTime * 2;
        return Thirst;
    }
    public float ManagerExhausted()
    {
        Exhausted -= (100 - Energy) * 0.01f;
        return Exhausted;
    }
    public float ManagerWC()
    {
        //WC -= Time.deltaTime * 2;
        return WC;
    }
    public float ManagerWorkDemand()
    {
        //
        return WorkDemand;
    }
    public float ManagerMentalHP()
    {
        //
        return MentalHP;
    }
    public float MangerLightDemand()
    {
        //
        return LightDemand;
    }
    float HP
    {
        get { return dataStorage.HP; }
        set { dataStorage.HP = value; }
    }
    float Hunger
    {
        get { return dataStorage.Hunger; }
        set { dataStorage.Hunger = value; }
    }
    float Thirst
    {
        get { return dataStorage.Thirst; }
        set { dataStorage.Thirst = value; }
    }
    float Energy
    {
        get { return dataStorage.Energy; }
        set { dataStorage.Energy = value; }
    }
    float WC
    {
        get { return dataStorage.WC; }
        set { dataStorage.WC = value; }
    }
    float Exhausted
    {
        get { return dataStorage.Exhausted; }
        set { dataStorage.Exhausted = value; }
    }
    float WorkDemand
    {
        get { return dataStorage.WorkDemand; }
        set { dataStorage.WorkDemand = value; }
    }
    float MentalHP
    {
        get { return dataStorage.MentalHP; }
        set { dataStorage.MentalHP = value; }
    }
    float LightDemand
    {
        get { return dataStorage.LightDemand; }
        set { dataStorage.LightDemand = value; }
    }
}
