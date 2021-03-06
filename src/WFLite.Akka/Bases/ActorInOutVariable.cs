﻿/*
 * ActorInOutVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */
 
using Akka.Actor;
using Microsoft.Extensions.Logging;
using WFLite.Bases;
using WFLite.Interfaces;
using WFLite.Logging.Bases;

namespace WFLite.Akka.Bases
{
    public abstract class ActorInOutVariable : LoggingInOutVariable
    {
        private readonly IActorContext _context;

        private readonly IActorRef _self;

        private readonly IActorRef _sender;

        public ActorInOutVariable(IActorContext context, IActorRef self, IActorRef sender, IConverter converter = null)
            : base(converter)
        {
            _context = context;
            _self = self;
            _sender = sender;
        }

        public ActorInOutVariable(ILogger logger, IActorContext context, IActorRef self, IActorRef sender, IConverter converter = null)
            : base(logger, converter)
        {
            _context = context;
            _self = self;
            _sender = sender;
        }

        protected sealed override object getValue()
        {
            return getValue(_context, _self, _sender);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_context, _self, _sender, value);
        }

        protected abstract object getValue(IActorContext context, IActorRef self, IActorRef sender);

        protected abstract void setValue(IActorContext context, IActorRef self, IActorRef sender, object value);
    }

    public abstract class ActorInOutVariable<TValue> : LoggingInOutVariable<TValue>
    {
        private readonly IActorContext _context;

        private readonly IActorRef _self;

        private readonly IActorRef _sender;

        public ActorInOutVariable(IActorContext context, IActorRef self, IActorRef sender, IConverter<TValue> converter = null)
            : base(converter)
        {
            _context = context;
            _self = self;
            _sender = sender;
        }

        public ActorInOutVariable(ILogger logger, IActorContext context, IActorRef self, IActorRef sender, IConverter<TValue> converter = null)
            : base(logger, converter)
        {
            _context = context;
            _self = self;
            _sender = sender;
        }

        protected sealed override object getValue()
        {
            return getValue(_context, _self, _sender);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_context, _self, _sender, value);
        }

        protected abstract object getValue(IActorContext context, IActorRef self, IActorRef sender);

        protected abstract void setValue(IActorContext context, IActorRef self, IActorRef sender, object value);
    }

    public abstract class ActorInOutVariable<TInValue, TOutValue> : LoggingInOutVariable<TInValue, TOutValue>
    {
        private readonly IActorContext _context;

        private readonly IActorRef _self;

        private readonly IActorRef _sender;

        public ActorInOutVariable(IActorContext context, IActorRef self, IActorRef sender, IConverter<TInValue, TOutValue> converter = null)
            : base(converter)
        {
            _context = context;
            _self = self;
            _sender = sender;
        }

        public ActorInOutVariable(ILogger logger, IActorContext context, IActorRef self, IActorRef sender, IConverter<TInValue, TOutValue> converter = null)
            : base(logger, converter)
        {
            _context = context;
            _self = self;
            _sender = sender;
        }

        protected sealed override object getValue()
        {
            return getValue(_context, _self, _sender);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_context, _self, _sender, value);
        }

        protected abstract object getValue(IActorContext context, IActorRef self, IActorRef sender);

        protected abstract void setValue(IActorContext context, IActorRef self, IActorRef sender, object value);
    }
}
