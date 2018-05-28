
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_MachineLearningComputeManagementClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("MachineLearningCompute", "MachineLearningCompute", "2017-08-01-preview"),
                new Tuple<string, string, string>("MachineLearningCompute", "OperationalizationClusters", "2017-08-01-preview"),
            }.AsEnumerable();
        }
    }
}
