using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AccumulateNV2(this TFGraph graph, TensorFlow.TFOutput[] inputs, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.AccumulateNV2(inputs, shape, operName);
		}
	}
}