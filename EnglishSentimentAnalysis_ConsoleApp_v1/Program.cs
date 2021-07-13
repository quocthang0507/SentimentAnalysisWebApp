﻿using System;

namespace EnglishSentimentAnalysis_ConsoleApp_v1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create single instance of sample data from first line of dataset for model input
			SentimentModel.ModelInput sampleData = new SentimentModel.ModelInput()
			{
				Comment = @"Đồ giống hình, nhìn khá xinh, giá rẻ, ship siêu nhanh luôn. Chưa dùng thử nên chưa biết thế nào",
			};

			// Make a single prediction on the sample data and print results
			var predictionResult = SentimentModel.Predict(sampleData);

			Console.WriteLine("Using model to make single prediction -- Comparing actual Col2 with predicted Col2 from sample data...\n\n");


			Console.WriteLine($"Col3: {sampleData.Comment}");


			Console.WriteLine($"\n\nPredicted Col2: {predictionResult.Prediction}\n\n");
			Console.WriteLine("=============== End of process, hit any key to finish ===============");
			Console.ReadKey();
		}
	}
}
