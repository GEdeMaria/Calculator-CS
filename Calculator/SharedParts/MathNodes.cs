using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace GEM.Calculator.MathNodes
{
    internal interface IMathNode
    {
        public double Solve();
        public string GetString();
    }
    internal interface IOperatorNode : IMathNode
    {
        public IMathNode NodeA {  get; }
    }
    internal interface IOperationNode : IOperatorNode
    {
        public IMathNode NodeB { get; }
    }

    internal class RootNode : IOperatorNode
    {
        public IMathNode NodeA => throw new NotImplementedException();

        public double Solve()
        {
            return NodeA.Solve();
        }
        public string GetString()
        {
            return NodeA.GetString();
        }
    }
    internal class ConstantNode : IMathNode
    {
        public double Value { get; set; }

        public ConstantNode(double value) { Value = value; }

        public double Solve()
        {
            return Value;
        }
        public string GetString()
        {
            return Value.ToString();
        }
    }

    internal class AdditionNode : IOperationNode
    {
        public IMathNode NodeB { get; set; }

        public IMathNode NodeA { get; set; }

        public AdditionNode(IMathNode nodeA, IMathNode nodeB)
        {
            NodeB = nodeB;
            NodeA = nodeA;
        }

        public double Solve()
        {
            return NodeB.Solve() + NodeA.Solve();
        }

        public string GetString()
        {
            return NodeA.GetString() + " + " + NodeB.GetString();
        }
    }
    internal class SubtractNode : IOperationNode
    {
        public IMathNode NodeA { get; set; }
        public IMathNode NodeB { get; set; }

        public SubtractNode(IMathNode nodeA, IMathNode nodeB)
        {
            NodeA = nodeA;
            NodeB = nodeB;
        }

        public double Solve()
        {
            return NodeA.Solve() - NodeB.Solve();
        }
        public string GetString()
        {
            return NodeA.GetString() + " - " + NodeB.GetString();
        }
    }
    internal class Product_Node : IOperationNode
    {
        public IMathNode NodeB { get; set; }

        public IMathNode NodeA { get; set; }

        public Product_Node(IMathNode nodeA, IMathNode nodeB)
        {
            NodeB = nodeB;
            NodeA = nodeA;
        }

        public double Solve()
        {
            return NodeA.Solve() * NodeB.Solve();
        }
        public string GetString()
        {
            return NodeA.GetString() + " * " + NodeB.GetString();
        }
    }
    internal class DivisionNode : IOperationNode
    {
        public IMathNode NodeB { get; set; }

        public IMathNode NodeA { get; set; }

        public DivisionNode(IMathNode nodeA, IMathNode nodeB)
        {
            NodeB = nodeB;
            NodeA = nodeA;
        }

        public double Solve()
        {
            return NodeA.Solve() / NodeB.Solve();
        }
        public string GetString()
        {
            return NodeA.GetString() + " / " + NodeB.GetString();
        }
    }

    internal class NegateNode : IOperatorNode
    {
        public IMathNode NodeA { get; set; }

        public NegateNode(IMathNode nodeA)
        {
            NodeA = nodeA;
        }

        public double Solve()
        {
            return -(NodeA.Solve());
        }
        public string GetString()
        {
            return "-(" + NodeA.GetString() + ")";
        }
    }
    internal class InvertNode : IOperatorNode
    {
        public IMathNode NodeA { get; set; }
        public InvertNode(IMathNode nodeA)
        {
            NodeA = nodeA;
        }
        public double Solve()
        {
            return 1 / NodeA.Solve();
        }
        public string GetString()
        {
            return "(1/" + NodeA.GetString() + ")";
        }
    }
    internal class SquareNode : IOperatorNode
    {
        public IMathNode NodeA { get; set; }

        public SquareNode(IMathNode nodeA)
        {
            NodeA = nodeA;
        }

        public double Solve()
        {
            return Math.Pow(NodeA.Solve(), 2);
        }
        public string GetString()
        {
            return "(" + NodeA.GetString() + "^2)";
        }
    }
    internal class SqRootNode : IOperatorNode
    {
        public IMathNode NodeA { get; set; }

        public SqRootNode (IMathNode nodeA)
        {
            NodeA = nodeA;
        }

        public double Solve()
        {
            return Math.Sqrt(NodeA.Solve());
        }
        public string GetString()
        {
            return "sqrt(" + NodeA.GetString() + ")";
        }
    }
}
