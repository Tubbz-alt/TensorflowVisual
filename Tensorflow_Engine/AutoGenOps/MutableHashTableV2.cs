using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput MutableHashTableV2(this TFGraph graph, TensorFlow.TFDataType key_dtype, TensorFlow.TFDataType value_dtype, string container=null, string shared_name=null, System.Boolean? use_node_name_sharing=null, string operName=null)
		{
			return graph.MutableHashTableV2(key_dtype, value_dtype, container, shared_name, use_node_name_sharing, operName);
		}
	}
}
