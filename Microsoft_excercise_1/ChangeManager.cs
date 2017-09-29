namespace Microsoft_excercise_1
{
    public class ChangeManager
    {
        public uint MakeChange(uint amount)
        {
            uint count = 0, occurence;
            byte[] coins = {100, 50, 20, 10, 5, 1};

            if (amount > 0)
            {
                for (uint i = 0; i < coins.Length; i++)
                {
                    occurence = amount / coins[i];
                    amount -= occurence * coins[i];
                    count += occurence;
                }
            }

            return count;
        }
    }
}
