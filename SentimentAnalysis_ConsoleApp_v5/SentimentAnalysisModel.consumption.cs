﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace SentimentAnalysis_ConsoleApp_v5
{
    public partial class SentimentAnalysisModel
    {
        /// <summary>
        /// model input class for SentimentAnalysisModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"userid")]
            public float Userid { get; set; }

            [ColumnName(@"mtime")]
            public string Mtime { get; set; }

            [ColumnName(@"rating_star")]
            public float Rating_star { get; set; }

            [ColumnName(@"comment")]
            public string Comment { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for SentimentAnalysisModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName("PredictedLabel")]
            public float Prediction { get; set; }

            public float[] Score { get; set; }
        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("SentimentAnalysisModel.zip");

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            MLContext mlContext = new MLContext();

            // Load model & create prediction engine
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            ModelOutput result = predEngine.Predict(input);
            return result;
        }
    }
}
