using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation BarrierClose(this TFGraph graph, TensorFlow.TFOutput handle, System.Boolean? cancel_pending_enqueues=null, string operName=null)
		{
			return graph.BarrierClose(handle, cancel_pending_enqueues, operName);
		}
	}
}
