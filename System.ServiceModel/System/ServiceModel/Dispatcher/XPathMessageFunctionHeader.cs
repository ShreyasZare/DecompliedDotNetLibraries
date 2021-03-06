﻿namespace System.ServiceModel.Dispatcher
{
    using System;
    using System.Xml.XPath;
    using System.Xml.Xsl;

    internal class XPathMessageFunctionHeader : XPathMessageFunction
    {
        private XPathExpression expr;

        public XPathMessageFunctionHeader() : base(new XPathResultType[0], 0, 0, XPathResultType.NodeSet)
        {
        }

        public override object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext)
        {
            if (this.expr == null)
            {
                XPathExpression expression = docContext.Compile("(/s11:Envelope/s11:Header | /s12:Envelope/s12:Header)[1]");
                expression.SetContext(XPathMessageFunction.Namespaces);
                this.expr = expression;
            }
            return docContext.Evaluate(this.expr);
        }

        internal override void InvokeInternal(ProcessingContext context, int argCount)
        {
            int iterationCount = context.IterationCount;
            context.PushSequenceFrame();
            if (iterationCount > 0)
            {
                NodeSequence seq = context.CreateSequence();
                seq.StartNodeset();
                SeekableXPathNavigator contextNode = context.Processor.ContextNode;
                long currentPosition = contextNode.CurrentPosition;
                if (XPathMessageFunction.MoveToHeader(contextNode))
                {
                    seq.Add(contextNode);
                }
                contextNode.CurrentPosition = currentPosition;
                seq.StopNodeset();
                context.PushSequence(seq);
                for (int i = 1; i < iterationCount; i++)
                {
                    context.PushSequence(seq);
                }
            }
        }
    }
}

