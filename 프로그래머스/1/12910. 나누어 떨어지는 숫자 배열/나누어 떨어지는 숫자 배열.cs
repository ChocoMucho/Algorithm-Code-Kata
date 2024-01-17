using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        
        List<int> list = new List<int>();
        
        for(int i=0; i<arr.Length; ++i)
        {
            if(arr[i] % divisor == 0)
                list.Add(arr[i]);
        }
        
        if(list.Count == 0)
        {
            int[] a = new int[1]{-1};
            return a;
        }
        
        list.Sort();
        
        return list.ToArray();
    }
}