using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static int GetTensorNumDims(this TFGraph graph, TensorFlow.TFOutput output, TensorFlow.TFStatus status=null)
		{
			return graph.GetTensorNumDims(output, status);
		}
	}
}
