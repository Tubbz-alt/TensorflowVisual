using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation StackClose(this TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.StackClose(handle, operName);
		}
	}
}