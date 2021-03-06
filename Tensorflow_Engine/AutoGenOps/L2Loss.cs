using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput L2Loss(this TFGraph graph, TensorFlow.TFOutput t, string operName=null)
		{
			return graph.L2Loss(t, operName);
		}
	}
}
