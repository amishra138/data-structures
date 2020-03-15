namespace _01_time_complexity
{
    /// <summary>
    ///  //1,3,-2,1,-3,0,2
    //1,3,-2
    //1,3,1
    //1,3,-3
    //1,3,0
    //1,3,2
    //Next triplet by increment j and reset k
    //1,-2,1
    //1,-2,1 ....
    /// </summary>
    public class TripletSum
    {
        public static int Count(int[] a)
        {
            int n = a.Length;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if(a[i] + a[j] + a[k] == 0)
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }
    }
}
