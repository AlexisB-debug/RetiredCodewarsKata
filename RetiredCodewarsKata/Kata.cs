namespace RetiredCodewarsKata;

public class Kata
{
    // A Western man is trying to find gold in a river. To do that, he passes a bucket through the river's soil and then
    // checks if it contains any gold. However, he could be more productive if he wrote an algorithm to do the job for him.
    // So, you need to check if there is gold in the bucket, and if so, return true. If not, return false.
    public bool ManInTheWest(string[] bucket)
    {
        string found = "gold";
        foreach (string suprise in bucket)
        {
            if (suprise == found)
            {
                return true;
            }
        }
        return false;
    }

    public string ManInTheWestAlternative(string[] bucket)
    {
        string found = "gold";
        foreach (string suprise in bucket)
        {
            if (suprise == found)
            {
                return "I will bye a teeth";
            }
        }
        return "Not today";
    }

    public List<int> AreArrowFunctionsOdd(List<int> values) =>
        values.Where(v => v % 2 != 0).ToList();
}
