using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation NoOp(this TFGraph graph, string operName=null)
		{
			return graph.NoOp(operName);
		}
	}
}
