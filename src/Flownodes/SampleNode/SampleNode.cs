﻿using CryEngine;
using CryEngine.FlowSystem;

namespace WhateverNamespaceTheNodeMakerWants
{
    [NodeCategory("Mono")] // Decides which category the node will appear in, inside the Flowgraph Editor.
    // The node name is actually the class name, no need to define it somewhere else!
    class SampleNode : IFlowNode // Basic functionality provided by the base FlowNode, all nodes inheriting from the FlowNode class will be registered automatically.
    {
        public SampleNode()
        {
            CryConsole.LogAlways("Constructing SampleNode");
        }

        ////////////////////////////////////////////////////
        public SFlowNodeConfig GetConfiguration()
	    {
            CryConsole.LogAlways("Retrieving flownode configuration");

            SFlowNodeConfig config = new SFlowNodeConfig();

            SInputPortConfig res = new SInputPortConfig("Start", EInputPortType.Void, "Start input");
		    SInputPortConfig[] inputs =
		    {
                new SInputPortConfig("Start", EInputPortType.Void, "Start input"),
                new SInputPortConfig("Cancel", EInputPortType.Void, "Cancel input")
		    };

		    SOutputPortConfig[] outputs =
		    {
			    new SOutputPortConfig("Started", EOutputPortType.Void, "Called on start"),
                new SOutputPortConfig("Cancelled", EOutputPortType.Void, "Called on cancel")
		    };

		    config.inputs = inputs;
		    config.outputs = outputs;
            config.description = "Does nothing!";
            config.category = EFlowNodeFlags.EFLN_DEBUG;

            return config;
	    }   

        public void ProcessEvent(IFlowNode.EFlowEvent _event, IFlowNode.SActivationInfo nodeInfo)
        {
            CryConsole.LogAlways("Process Event; Mono style.");

            switch (_event)
            {
                case EFlowEvent.Activate:
                    {/*
                        if (IsPortActive(nodeInfo, (int)EInputPorts.EIP_Start))
                        {
                            ActivateOutput(nodeInfo, (int)EOutputPorts.EOP_Started);
                        }*/
                    }
                    break;
            }
        }
    }
}