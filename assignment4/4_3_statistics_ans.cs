using System;
using System.Linq;

namespace statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = {
                {"StdNum", "Name", "Math", "Science", "English"},
                {"1001", "Alice", "85", "90", "78"},
                {"1002", "Bob", "92", "88", "84"},
                {"1003", "Charlie", "79", "85", "88"},
                {"1004", "David", "94", "76", "92"},
                {"1005", "Eve", "72", "95", "89"}
            };
            // You can convert string to double by
            // double.Parse(str)

            int stdCount = data.GetLength(0) - 1;
            // ---------- TODO ----------
            double[] score = {0, 0, 0};
            for(int i = 0; i <= 2 ;i++){
                for(int j = 1; j <= 5; j++){
                    score[i] = score[i] + double.Parse(data[j, i+2]);
                }
            }
            Console.Write("Average Scores:\nMath: " + score[0] / stdCount);
            Console.Write("\nScience: " + score[1] / stdCount);
            Console.Write("\nEnglish: " + score[2] / stdCount);
            
            double[] max = {0, 0, 0};
            double[] min = {100, 100, 100};
            for(int k = 1; k <= 5; k++){
                if(max[0] < double.Parse(data[k, 2])){
                    max[0] = double.Parse(data[k, 2]);
                }
                if(max[1] < double.Parse(data[k, 3])){
                    max[1] = double.Parse(data[k, 3]);
                }
                if(max[2] < double.Parse(data[k, 4])){
                    max[2] = double.Parse(data[k, 4]);
                }
                if(min[0] > double.Parse(data[k, 2])){
                    min[0] = double.Parse(data[k, 2]);
                }
                if(min[1] > double.Parse(data[k, 3])){
                    min[1] = double.Parse(data[k, 3]);
                }
                if(min[2] > double.Parse(data[k, 4])){
                    min[2] = double.Parse(data[k, 4]);
                }
            }
            Console.Write("\n\nMax and min Score:\nMath: (" + max[0] + ", " + min[0] + ")");
            Console.Write("\nScience: (" + max[1] + "," + min[1] + ")");
            Console.Write("\nEnglish: (" + max[2] + "," + min[2] + ")");
            
            double[] sum = {0, 0, 0, 0, 0};
            for(int l = 1; l <= 5; l++){
                for(int p = 2; p <= 4; p++){
                    sum[l-1] = sum[l-1] + double.Parse(data[l, p]);
                }
            }
            int[] rank = {1, 1, 1, 1, 1};
            for(int t = 0; t <= 4; t++){
                for(int u = 0; u <= 4; u++){
                    if(sum[t] < sum[u]){
                        rank[t]++;
                    }
                }
            }
            string[] rank_W = {"", "", "", "", ""};
            for(int q = 0; q <= 4; q++){
                if(rank[q] == 1){
                    rank_W[q] = "1st";
                }
                else if(rank[q] == 2){
                    rank_W[q] = "2nd";
                }
                else if(rank[q] == 3){
                    rank_W[q] = "3rd";
                }
                else if(rank[q] == 4){
                    rank_W[q] = "4th";
                }
                else if(rank[q] == 5){
                    rank_W[q] = "5th";
                }
            }
            Console.Write("\n\nStudents rank by total scores:\n");
            Console.Write("Alice: " + rank_W[0]);
            Console.Write("\nBob: " + rank_W[1]);
            Console.Write("\nCharlie: " + rank_W[2]);
            Console.Write("\nDavid: " + rank_W[3]);
            Console.Write("\nEve: " + rank_W[4]);
            // --------------------
        }
    }
}

/* example output

Average Scores: 
Math: 84.40
Science: 86.80
English: 86.20

Max and min Scores: 
Math: (94, 72)
Science: (95, 76)
English: (92, 78)

Students rank by total scores:
Alice: 2nd
Bob: 5th
Charlie: 1st
David: 4th
Eve: 3rd

*/
