using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput NotEqual(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput y, string operName=null)
		{
			return graph.NotEqual(x, y, operName);
		}
	}
}
