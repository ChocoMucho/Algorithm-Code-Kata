using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int bridge_length, int weight, int[] truck_weights) {
        int tick = 0;
        int index = 0;  
        int currentTotalWeight = 0; // 현재 다리가 받치는 무게
        int complete = 0;
        Queue<(int weight, int check)> queue = new Queue<(int, int)>();
        
        queue.Enqueue((truck_weights[index], tick++)); // 7집어넣고
        currentTotalWeight = truck_weights[index++];
        
        while(complete < truck_weights.Length)
        {
            
            if(queue.Count > 0)
            {
                (int weight, int check) truck = queue.Peek();
                //트럭 뺄지 체크
                if(truck.check + bridge_length == tick) // 빠질 시간
                {
                    queue.Dequeue();
                    currentTotalWeight -= truck.weight;
                    ++complete;
                }
            }            
            
            // 무게 체크 후 트럭 추가
            if(index < truck_weights.Length && currentTotalWeight + truck_weights[index] <= weight)
            {
                queue.Enqueue((truck_weights[index], tick));
                currentTotalWeight += truck_weights[index++];
            }           
            
            ++tick;
        }      
        
        return tick;
    }
}