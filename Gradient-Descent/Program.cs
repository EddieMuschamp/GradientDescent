using System;
using System.Collections.Generic;

namespace Gradient_Descent
{
    class Program
    {
        static void Main(string[] args)
        {
            float output;
            float newWeight;
            int dataCounter = 0;
            List<float> weights = new List<float> { 0.5f, -0.1f, 0.2f };
            string[] lines = System.IO.File.ReadAllLines(@"data-OR.txt");
            foreach (string line in lines)
            {
                dataCounter += 1;
                int epoch = 100;
                string[] data;
                data = line.Split(' ');
                List<int> inputs = new List<int>();
                inputs.Add(Int32.Parse(data[0]));
                inputs.Add(Int32.Parse(data[1]));
                inputs.Add(Int32.Parse(data[2]));
                int expOutput = Int32.Parse(data[3]);
                while (epoch != 0)
                {
                    Console.WriteLine("==========");
                    Console.WriteLine("Data Line: " + dataCounter);
                    Console.WriteLine("Epoch: " + (101-epoch));
                    output = TotalOutput(inputs, weights);

                    for (int i = 0; i < inputs.Count; i++)
                    {
                        newWeight = NewWeight(weights[i], expOutput, output, inputs[i]);
                        //Console.WriteLine(newWeight);
                        weights[i] = newWeight;
                    }
                    epoch -= 1;
                    Console.WriteLine("==========");
                }

                float TotalOutput(List<int> inputs, List<float> weights)
                {
                    float output = 0;
                    float net = 0;
                    for (int i = 0; i < inputs.Count; i++)
                    {
                        net += inputs[i] * weights[i];
                    }
                    //Console.WriteLine(net);
                    output = (float)(1 / (1 + Math.Exp(-net)));
                    Console.WriteLine("Ouput: " + output);
                    Console.WriteLine("Error: " + (expOutput - output));
                    return output;
                }

                float NewWeight(float weight, int expOutput, float output, int input)
                {
                    float newWeight;
                    float changeWeight;
                    changeWeight = 0.05f * (expOutput - output) * input;
                    //Console.WriteLine(changeWeight);
                    newWeight = weight + changeWeight;
                    return newWeight;
                }


            } 
            
        }

        
    }
}
