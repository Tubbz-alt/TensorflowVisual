using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SparseToDense(this TFGraph graph, TensorFlow.TFOutput sparse_indices, TensorFlow.TFOutput output_shape, TensorFlow.TFOutput sparse_values, TensorFlow.TFOutput default_value, System.Boolean? validate_indices=null, string operName=null)
		{
			return graph.SparseToDense(sparse_indices, output_shape, sparse_values, default_value, validate_indices, operName);
		}
	}
}
