public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        Array.Reverse(piles);
        int sum = 0;
        int n = piles.Length / 3;
        for (int i = 1; i < piles.Length - n; i = i + 2)
        {
            sum += piles[i];
        }
        return sum;
    }
}
//20260102