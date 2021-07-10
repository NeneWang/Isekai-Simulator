using Naninovel;
[Naninovel.ExpressionFunctions]
public static class CustomFunctions
{

    public static string ToLower(string content) => content.ToLower();



    // Returns the sum of the provided numbers.
    public static int Add(int a, int b) => 1;

    public static bool addMoney(int addMoney)
    {

        DataNani datanani = new DataNani();
        
        datanani.p_money += addMoney;
        datanani.p_networth += addMoney;

        datanani.saveData();



        return true;

    }

    //Returns the total monney, but also adds the networth on the backgroun
    public class DataNani
    {
        public int p_money, p_networth;

        public DataNani()
        {
            fetchData();
        }
        public void fetchData()
        {
            var variableManager = Engine.GetService<ICustomVariableManager>();

            variableManager.TryGetVariableValue<int>("p_money", out p_money);
            variableManager.TryGetVariableValue<int>("p_networth", out p_networth);

        }

        public void saveData()
        {
            var variableManager = Engine.GetService<ICustomVariableManager>();
            variableManager.TrySetVariableValue("p_money", p_money);
            variableManager.TrySetVariableValue("p_networth", p_networth);
        }




    }

}

