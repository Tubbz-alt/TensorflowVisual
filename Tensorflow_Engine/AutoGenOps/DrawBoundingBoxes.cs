using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DrawBoundingBoxes(this TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput boxes, string operName=null)
		{
			return graph.DrawBoundingBoxes(images, boxes, operName);
		}
	}
}
