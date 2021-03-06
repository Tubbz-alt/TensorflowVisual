using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PaddedBatchDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput batch_size, TensorFlow.TFOutput[] padded_shapes, TensorFlow.TFOutput[] padding_values, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.PaddedBatchDataset(input_dataset, batch_size, padded_shapes, padding_values, output_shapes, operName);
		}
	}
}
