﻿
using UnityEngine;

namespace BlueGraph.Tests
{
    public class TestClass
    {
        public float value1;
        public float value2;
    }

    public struct TestStruct
    {
        public float value1;
        public float value2;
    }

    /// <summary>
    /// Test fixture with a bunch of type options to check GetInputValue calls
    /// </summary>
    public class TypeTestNode : AbstractNode
    {
        public int intValue;
        public bool boolValue;
        public string stringValue;
        public float floatValue;
        public Vector3 vector3Value;
        public AnimationCurve curveValue;

        public TestClass testClassValue = new TestClass();
        public TestStruct testStructValue;
    
        public TypeTestNode() : base()
        {
            name = "Type Test Node";
        }

        public override void OnRequestPorts()
        {
            // Input (any)
            AddPort(new Port { isInput = true, name = "Input" });

            // Output types
            AddPort(new OutputPort<int> { name = "intval" });
            AddPort(new OutputPort<bool> { name = "boolval" });
            AddPort(new OutputPort<int> { name = "stringval" });
            AddPort(new OutputPort<float> { name = "floatval" });
            AddPort(new OutputPort<Vector3> { name = "vector3val" });
            AddPort(new OutputPort<AnimationCurve> { name = "curveval" });
            AddPort(new OutputPort<TestClass> { name = "classval" });
            AddPort(new OutputPort<TestStruct> { name = "structval" });
        }

        public override object OnRequestValue(Port port)
        {
            switch (port.name)
            {
                case "intval": return intValue;
                case "boolval": return boolValue;
                case "stringval": return stringValue;
                case "vector3val": return vector3Value;
                case "curveval": return curveValue;
                case "classval": return testClassValue;
                case "structval": return testStructValue;
            }
            return base.OnRequestValue(port);
        }
    }
}
