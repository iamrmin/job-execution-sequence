﻿namespace JobExecutionSequence
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                throw new ArgumentNullException($"No file path given");

            var rawFileText = File.ReadAllText(args[0]);
            var jobDependencyService = new JobDependencyService(rawFileText);
            var output = jobDependencyService.EvaluateJobSequence();

            Console.WriteLine(output);
        }
    }
}
