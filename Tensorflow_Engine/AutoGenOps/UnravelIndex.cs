using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput UnravelIndex(this TFGraph graph, TensorFlow.TFOutput indices, TensorFlow.TFOutput dims, string operName=null)
		{
			return graph.UnravelIndex(indices, dims, operName);
		}
	}
}
